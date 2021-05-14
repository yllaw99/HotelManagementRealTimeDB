using FireSharp.Interfaces;
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

namespace HotelManagement_FireBase
{
    public partial class FormCheckOut : Form
    {        
        #region initial
        public FormCheckOut(FormRoom frm)
        {
            InitializeComponent();
            this.fr = frm;
        }
        FormRoom fr;
        DataProvider data = new DataProvider();
        #endregion
        #region connect to db
        DataProvider provider = new DataProvider();
        IFirebaseClient client = DataProvider.Instance.connect();
        #endregion
        #region click events
        private void button_pay_Click(object sender, EventArgs e)
        {
            string roomID = label_roomID.Text;
            Room roomInfo = provider.getRoomInfo(roomID);
            string dCheckOut = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
            var update = client.Set("Rooms/" + label_roomID.Text + "/status", "Trống");
            client.Set("Rooms/" + label_roomID.Text + "/dateCheckIn", "");
            client.Set("Bills/" + roomInfo.DateCheckIn.ToString() + "/" + roomID + "/DCheckOut/", dCheckOut);
            if (update.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Check out thành công!!", "Thông báo", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Lỗi khi Check out", "Thông báo", MessageBoxButtons.OK);

            this.Close();
        }
        #endregion
        #region fomr load
        private void FormCheckOut_Load(object sender, EventArgs e)
        {
            string today = DateTime.Now.Hour.ToString() + "H" + DateTime.Now.Minute.ToString() + " " + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
            Room roomInfo = data.getRoomInfo(fr.rID);
            Bill billin4 = data.getBillInfo(roomInfo.DateCheckIn.ToString(), fr.rID);
            
            this.label_roomID.Text = fr.rID;
            this.label_cusName.Text = billin4.CusName.ToString();
            this.label_address.Text = billin4.Address.ToString();
            this.label_roomType.Text = roomInfo.type.ToString();
            this.label_dateCheckOut.Text = today;
            this.label_dateCheckIn.Text = roomInfo.DateCheckIn.ToString();
            this.label_roomPrice.Text = roomInfo.Price.ToString();
        }

        void pricing(string originalPrice, string dateCheckIn,  string dateCheckOut)
        {

        }
        #endregion
    }
}
