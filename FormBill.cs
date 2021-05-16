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
            this.label_datenow.Text = DateTime.Now.Hour.ToString() + "H" + DateTime.Now.Minute.ToString() + " " + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
            this.label_CusName.Text = BillInfo.CusName.ToString();
            this.label_arrivalDate.Text = dci.Substring(dci.IndexOf(" "), dci.Length - dci.IndexOf(" "));
            this.label_contact.Text = BillInfo.Contact.ToString();
            this.label_roomID.Text = roomID;
            this.label_address.Text = BillInfo.Address.ToString();
            this.label_room_type.Text = roomInfo.type;
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

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region printing
        Bitmap bitmap;
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        
        private void button_print_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = new System.Drawing.Size(610, 560);
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        } 
        #endregion
    }
}
