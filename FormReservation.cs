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
            FirebaseResponse res = client.Get(@"Rooms/" + textBox_roomID.Text);
            Booking();
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region
        void Booking()
        {

        }

        #endregion

        #region Declare
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
