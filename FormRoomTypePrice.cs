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
    public partial class FormRoomTypePrice : Form
    {
        #region initial
        public FormRoomTypePrice()
        {
            InitializeComponent();
        }
        #endregion

        DataProvider provider = new DataProvider();

        #region click events
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.comboBox1.DroppedDown = true;
        }
        #endregion
        #region form load
        private void FormRoomTypePrice_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = provider.roomPrices();
        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox_roomType.Text = comboBox1.SelectedItem.ToString();
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thanh toán?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                updateRoomPrice();
            }
        }

        void updateRoomPrice()
        {
            IFirebaseClient client = provider.connect();
            var update = client.Set("RoomPrices/" + textBox_roomType.Text, textBox_price.Text);
            if (update.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Cập nhật giá phòng thành công!!", "Thông báo", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Lỗi khi cập nhật giá phòng ", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
