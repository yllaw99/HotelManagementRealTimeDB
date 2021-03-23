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
    public partial class FormRoom : Form
    {
        public FormRoom()
        {
            InitializeComponent();
        }

        #region Button Account Manager
        private void button_accManager_Click(object sender, EventArgs e)
        {
            FormAccountList fal = new FormAccountList();
            fal.ShowDialog();
        }
        #endregion
    }
}
