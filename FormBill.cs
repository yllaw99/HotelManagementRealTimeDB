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
    public partial class FormBill : Form
    {
        public FormBill()
        {
            InitializeComponent();
        }

        private void FormBill_Load(object sender, EventArgs e)
        {
            label_bill_id.Text = "";
            label_customer_name.Text = "";
            label_address.Text = "";
            label_phoneNum.Text = "";
            label_dateCheckIn.Text = "";
            label_dateCheckOut.Text = "";
        }
    }
}
