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
    public partial class FormReservation : Form
    {
        FormRoom fr;
        public FormReservation(FormRoom frm)
        {
            InitializeComponent();
            this.fr = frm;
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReservation_Load(object sender, EventArgs e)
        {
            this.textBox_roomID.Text = fr.rID;            
        }
    }
}
