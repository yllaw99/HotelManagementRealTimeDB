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
    public partial class FormCheckIn : Form
    {
        FormRoom fr;
        #region connect to db
        DataProvider provider = new DataProvider();
        IFirebaseClient client = DataProvider.Instance.connect();
        #endregion
        #region initial
        public FormCheckIn(FormRoom frm)
        {
            InitializeComponent();
            this.fr = frm;
        }
        #endregion
        #region formLoad
        private void FormCheckIn_Load(object sender, EventArgs e)
        {
            string roomID = fr.rID;
            string dCheckIn = DataProvider.Instance.getdCheckIn(roomID);
            Bill BillInfo = DataProvider.Instance.getBillInfo(dCheckIn, roomID);
            this.label_roomID.Text = fr.rID;
            this.label_cusName.Text = BillInfo.CusName.ToString();
        }
        #endregion
        #region Booking Cancel
        private void button_bookingCancel_Click(object sender, EventArgs e)
        {
            string roomID = fr.rID;
            string dCheckIn = DataProvider.Instance.getdCheckIn(roomID);
            string dCheckOut = "Đã huỷ";
            var update = client.Set("Rooms/" + label_roomID.Text + "/status", "Trống");
            client.Set("Rooms/" + label_roomID.Text + "/dateCheckIn", "");
            client.Set("Bills/" + dCheckIn + "/" + roomID + "/DCheckOut/", dCheckOut);
            if (update.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Huỷ đặt phòng thành công!!", "Thông báo", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Lỗi khi huỷ đặt phòng", "Thông báo", MessageBoxButtons.OK);

            this.Close();
        }
        #endregion

        #region confirm
        private void button_confirm_Click(object sender, EventArgs e)
        {
            string billid = DataProvider.Instance.getdCheckIn(fr.rID);
            Bill billinfo = DataProvider.Instance.getBillInfo(billid, fr.rID);
            string confirmID = textBox_checkInID.Text;
            if (textBox_checkInID.Text == billinfo.CMND.ToString())
            {
                MessageBox.Show("Nhận phòng thành công!!", "Thông báo", MessageBoxButtons.OK);
                var update = client.Set("Rooms/" + label_roomID.Text + "/status", "Có người");
                this.Close();
            }else
                MessageBox.Show("Mã không đúng, vui lòng nhập lại!!", "Thông báo", MessageBoxButtons.OK);
        }
        #endregion
    }
}
