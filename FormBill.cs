#region import things
using FireSharp.Interfaces;
using FireSharp.Response;
using HotelManagement_FireBase.DAO;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Drawing.Printing;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
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
        #region initial
        public FormBill(FormRoom frm)
        {
            InitializeComponent();
            this.fr = frm;
        }
        #endregion

        #region Load Form
        private void FormBill_Load(object sender, EventArgs e)
        {
            string roomID = fr.rID;
            Room roomInfo = provider.getRoomInfo(roomID);
            Bill BillInfo = provider.getBillInfo(roomInfo.DateCheckIn.ToString(), roomID);

            string dci = BillInfo.DCheckIn.ToString(); 
            this.label_CusName.Text = BillInfo.CusName.ToString();
            this.label_arrivalDate.Text = dci.Substring(dci.IndexOf(" "), dci.Length - dci.IndexOf(" "));
            this.label_contact.Text = BillInfo.Contact.ToString();
            this.label_roomID.Text = roomID;
            this.label_address.Text = BillInfo.Address.ToString();
            this.label_reservationType.Text = BillInfo.ReservationType.ToString();
            this.label_info.Text = "Ngày nhận: Ngày " + DateTime.Now.Day.ToString() + " Tháng " + DateTime.Now.Month.ToString() + " Năm " + DateTime.Now.Year.ToString(); ;
        }
        #endregion  

        #region click events
        void checkOut()
        {
            FormCheckOut fco = new FormCheckOut(fr);
            fco.ShowDialog();
        }

        private void button_checkOut_Click(object sender, EventArgs e)
        {
            checkOut();
        }
        #endregion

    }
}
