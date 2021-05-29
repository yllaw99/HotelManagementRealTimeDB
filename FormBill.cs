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
using System.Globalization;

#endregion

namespace HotelManagement_FireBase
{
    public partial class FormBill : Form
    {
        private int totalTempPrice;

        private int penalty;

        private int tax;

        private int totalFinal;

        private int taxPrice;

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

            string roomPrice = "";

            Room roomInfo = provider.getRoomInfo(roomID);

            Bill BillInfo = provider.getBillInfo(roomInfo.DateCheckIn.ToString(), roomID);

            string getday_arrival = BillInfo.DCheckIn.ToString();

            List<KeyValuePair<string, string>> listPrice = provider.roomPrices();

            string formatted_day = getday_arrival.Substring(6, 10);
            DateTime dayNow = DateTime.Now;
            DateTime dayArrived = new DateTime();
            DateTime.TryParseExact(formatted_day, "dd-MM-yyyy", null, DateTimeStyles.None, out dayArrived);

            foreach (var i in listPrice)
            {
                if (i.Key.ToString() == roomInfo.type.ToString())
                    roomPrice = i.Value;
            }

            this.comboBox_discount.DataSource = provider.getDiscount();
            this.label_datenow.Text = dayNow.ToString("HH:mm dd-MM-yyyy"); 
            this.label_arrivalDate.Text = BillInfo.DCheckIn.ToString();
            this.label_CusName.Text = BillInfo.CusName.ToString();
            this.label_contact.Text = BillInfo.Contact.ToString();
            this.label_address.Text = BillInfo.Address.ToString();
            this.label_roomID.Text = roomID;
            this.label_room_type.Text = roomInfo.type;
            this.label_price.Text = roomPrice.ToString();
            this.label_quantity.Text = cal_night(dayArrived, dayNow).ToString();
            this.label_total_temp.Text = (cal_night(dayArrived, dayNow) * Convert.ToInt32(roomPrice)).ToString();

            totalTempPrice = Convert.ToInt32(label_total_temp.Text);

            penalty = Convert.ToInt32(textBox_penalty.Text);

            tax = Convert.ToInt32(textBox_tax.Text);

            taxPrice =  ((totalTempPrice + penalty) * tax/100);

            totalFinal = totalTempPrice + penalty + taxPrice;

            this.label_total_final.Text = totalFinal.ToString();

        }
        #endregion  

        #region click events
        private void button_discount_Click(object sender, EventArgs e)
        {
            discount();
        }

        private void button_checkOut_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn thanh toán?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                checkOut();
            }
            this.Close();
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
            Size formSize = new System.Drawing.Size(610, 600);
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

        #region methods
        private void discount()
        {
            String selectedComboBoxItem = this.comboBox_discount.SelectedItem.ToString();
            int startIndex = selectedComboBoxItem.IndexOf(",")+2;
            int length = selectedComboBoxItem.Length - startIndex -1;
            String voucherCode = selectedComboBoxItem.Substring(startIndex, length);
            Int32 discountValue = Int32.Parse(voucherCode);
            Int32 preDiscountTotal = Int32.Parse(label_total_final.Text);

            int discountedTotal = preDiscountTotal * discountValue / 100;
            discountedTotal = preDiscountTotal - discountedTotal;
            this.label_total_final.Text = discountedTotal.ToString(); 
        }

        int cal_night(DateTime dayin, DateTime dayout)
        {
            int nights = Convert.ToInt16((dayout - dayin).TotalDays);
            return nights;
        }

        private void checkOut()
        {
            string roomID = label_roomID.Text;
            Room roomInfo = provider.getRoomInfo(roomID);
            string dCheckOut = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
            var update = client.Set("Rooms/" + label_roomID.Text + "/status", "Trống");
            client.Set("Rooms/" + label_roomID.Text + "/dateCheckIn", "");
            client.Set("Bills/" + roomInfo.DateCheckIn.ToString() + "/" + roomID + "/DCheckOut/", dCheckOut);
            client.Set("Bills/" + roomInfo.DateCheckIn.ToString() + "/" + roomID + "/Total/", this.label_total_final.Text);
            client.Set("Bills/" + roomInfo.DateCheckIn.ToString() + "/" + roomID + "/voucherUsed/", this.comboBox_discount.SelectedItem.ToString());
            if (update.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Check out thành công!!", "Thông báo", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Lỗi khi Check out", "Thông báo", MessageBoxButtons.OK);
        }
        #endregion

    }
}
