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

        public FormReservation(FormRoom frm)
        {
            InitializeComponent();
            this.fr = frm;
        }

        #region Form Load
        private void FormReservation_Load(object sender, EventArgs e)
        {
            this.textBox_roomID.Text = fr.rID;
        }
        #endregion

        #region Event Click
        private void button_booking_Click(object sender, EventArgs e)
        {
            Booking();
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region function
        void Booking()
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đặt phòng?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                FirebaseResponse se = client.Update("Bills/" + textBox_roomID.Text, Declare_Bill());
                if (se.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    FirebaseResponse update = client.Set("Rooms/" + textBox_roomID.Text + "/status", "Có người");
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
        private Room Declare_Room()
        {
            Room r = new Room()
            {
                status = "Có người"
            };

            return r;
        }

        private Bill Declare_Bill()
        {
            Bill bill = new Bill()
            {
                RoomID = this.textBox_roomID.Text,
                DCheckIn = this.dateTimePicker_checkIn.Text,

            };

            return bill;
        }
        #endregion
    }
}
