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
    }
}
