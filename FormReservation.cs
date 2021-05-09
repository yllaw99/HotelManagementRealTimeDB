#region import things
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Newtonsoft.Json;
using HotelManagement_FireBase.DAO;
#endregion

namespace HotelManagement_FireBase
{
    public partial class FormReservation : Form
    {
        FormRoom fr;
        #region connect to db
        DataProvider provider = new DataProvider();
        IFirebaseClient client = DataProvider.Instance.connect();
        #endregion
        #region initial
        public FormReservation(FormRoom frm)
        {
            InitializeComponent();
            this.fr = frm;
        }
        #endregion
        #region Form Load
        private void FormReservation_Load(object sender, EventArgs e)
        {
            this.dateTimePicker_checkIn.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker_checkIn.CustomFormat = "dd-MM-yyyy";
            this.textBox_roomID.Text = fr.rID;            
        }
        #endregion

        #region Event Click
        private void button_booking_Click(object sender, EventArgs e)
        {
            Booking();
            this.Close();
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_guaranteed.Checked)
            {
                this.radioButton1.Visible = false;
                this.radioButton2.Visible = false;
            }
            else
            {
                this.radioButton1.Visible = true;
                this.radioButton2.Visible = true;
            }
        }
        #endregion

        #region function
        string getPaymentMethod()
        {
            string pMethod = "";
            if (radioButton1.Checked)
            {
                pMethod = radioButton1.Text;
            }
            else
            {
                pMethod = radioButton2.Text;
            }
            return pMethod;
        }

        string getReservationType()
        {
            string ReType = "";
            if (radioButton_guaranteed.Checked)
            {
                ReType = radioButton_guaranteed.Text;
            }
            else
            {
                ReType = radioButton_nonGuaranteed.Text;
            }
            return ReType;
        }


        void Booking()
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đặt phòng?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                string dateCheckin = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
                FirebaseResponse se = client.Update("Bills/" + dateCheckin + "/" + textBox_roomID.Text + "/", Declare_Bill());
                if (se.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    FirebaseResponse update = client.Set("Rooms/" + textBox_roomID.Text + "/status", "Có người");
                    update = client.Set("Rooms/" + textBox_roomID.Text + "/dateCheckIn", dateCheckin);
                    MessageBox.Show("Đặt phòng thành công!!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Lỗi khi tạo tài khoản", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        #endregion

        #region Declare
        private Bill Declare_Bill()
        {
            Bill bill = new Bill()
            {
                RoomID = textBox_roomID.Text,
                CusName = textBox_fullname.Text,
                CMND = textBox_cmnd.Text,
                DCheckIn = DateTime.Now.Hour.ToString() + "H" + DateTime.Now.Minute.ToString() + " " + dateTimePicker_checkIn.Text,
                DCheckOut = "",
                Address = textBox_address.Text,
                Contact = textBox_contact.Text,
                ReservationType = getReservationType(),
                PaymentMethod = getPaymentMethod()
            };
            return bill;
        }
        #endregion





    }
}
