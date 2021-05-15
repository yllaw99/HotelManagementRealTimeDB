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
            this.panel_cardID.Enabled = false;
            this.panel_cardEXP.Enabled = false;
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

        private void button_reserve_Click(object sender, EventArgs e)
        {
            reserve();
            this.Close();
        }

        private void radioButton_nonGuaranteed_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            textBox_cardID.Text = "";
            textBox_creditCardExpDate.Text = "";
            radioButton_cash.Text = "";
            radioButton_creditCard.Text = "";
            radioButton_cash.Checked = true;
        }

        private void radioButton_guaranteed_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            radioButton_cash.Text = "Tiền mặt";
            radioButton_creditCard.Text = "Thẻ tín dụng";
        }

        private void radioButton_cash_CheckedChanged(object sender, EventArgs e)
        {
            panel_cardID.Enabled = false;
            panel_cardEXP.Enabled = false;
            textBox_cardID.Text = "";
            textBox_creditCardExpDate.Text = "";
        }

        private void radioButton_creditCard_CheckedChanged(object sender, EventArgs e)
        {
            panel_cardID.Enabled = true;
            panel_cardEXP.Enabled = true;
        }
        #endregion

        #region function
        #region Payment Method
        string getPaymentMethod()
        {
            string pMethod = "";
            if (radioButton_creditCard.Checked)
            {
                pMethod = radioButton_creditCard.Text;
            }
            else
            {
                pMethod = radioButton_cash.Text;
            }
            return pMethod;
        }
        #endregion
        #region Reservation Type
        string getReservationType()
        {
            string ReType = "";
            if (radioButton_guaranteed.Checked == true)
            {
                ReType = radioButton_guaranteed.Text;
            }
            else
            {
                ReType = radioButton_nonGuaranteed.Text;
            }
            return ReType;
        }
        #endregion
        #region Booking
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
                    MessageBox.Show("Lỗi khi đặt phòng", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        #endregion
        #region reserve
        void reserve()
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn giữ phòng?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                string dateCheckin = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
                FirebaseResponse se = client.Update("Bills/" + dateCheckin + "/" + textBox_roomID.Text + "/", Declare_Bill());
                if (se.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    FirebaseResponse update = client.Set("Rooms/" + textBox_roomID.Text + "/status", "Đã đặt");
                    update = client.Set("Rooms/" + textBox_roomID.Text + "/dateCheckIn", dateCheckin);
                    MessageBox.Show("Giữ phòng thành công!!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Lỗi khi giữ phòng", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        #endregion

        #endregion

        #region Declare
        private Bill Declare_Bill()
        {
            Bill bill = new Bill()
            {
                CusName = textBox_fullname.Text,
                CMND = textBox_cmnd.Text,
                DCheckIn = DateTime.Now.Hour.ToString() + "H" + DateTime.Now.Minute.ToString() + " " + dateTimePicker_checkIn.Text,
                DCheckOut = "",
                Address = textBox_address.Text,
                Contact = textBox_contact.Text,
                ReservationType = getReservationType(),
                Payment = getPaymentMethod(),
                CreditCardID = textBox_cardID.Text,
                CardExpDate = textBox_creditCardExpDate.Text,
                PromoType = textBox_promoCode.Text
            };
            return bill;
        }
        #endregion


    }
}
