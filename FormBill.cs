#region import things
using FireSharp.Interfaces;
using FireSharp.Response;
using HotelManagement_FireBase.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
#endregion

namespace HotelManagement_FireBase
{
    public partial class FormBill : Form
    {
        FormRoom fr;
        #region connect to db
        DataProvider provider = new DataProvider();
        IFirebaseClient client = DataProvider.Instance.connect();
        #endregion
        public FormBill(FormRoom frm)
        {
            InitializeComponent();
            this.fr = frm;
        }
        #region Load Form
        private void FormBill_Load(object sender, EventArgs e)
        {
            string roomID = fr.rID;
            string dCheckIn = getdCheckIn(roomID);
            Bill BillInfo = getBillInfo(dCheckIn, roomID);

            this.label_CusName.Text = BillInfo.CusName.ToString();
            this.label_arrivalDate.Text = BillInfo.Address.ToString();
            this.label_departureDate.Text = BillInfo.DCheckOut.ToString();
            this.label_contact.Text = BillInfo.Contact.ToString();
            this.label_roomID.Text = roomID;
            this.label_address.Text = BillInfo.Address.ToString();
        }
        #endregion

        #region Function
        string getdCheckIn(string roomID) //input = RoomID //output = dCheckIn
        {
            FirebaseResponse data = client.Get(@"Rooms/" + roomID);
            Room RoomInfo = data.ResultAs<Room>();
            string dateCheckIn = RoomInfo.dateCheckIn.ToString();
            return dateCheckIn;
        }

        Bill getBillInfo(string dCheckIn, string roomID)
        {
            FirebaseResponse data = client.Get("Bills/" + dCheckIn + "/" + roomID);
            Bill billInfo = data.ResultAs<Bill>();
            return billInfo;
        }
        #endregion

    }
}
