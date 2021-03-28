using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using HotelManagement_FireBase.DAO;
using Newtonsoft.Json;


namespace HotelManagement_FireBase
{
    public partial class Form_Customers : Form
    {
        public Form_Customers()
        {
            InitializeComponent();
            textBox_customer_phoneNum.MaxLength = 10;
            textBox_customer_CMND.MaxLength = 12;
            comboBox_blackList.Text = "0";
        }

        #region connect to DB
        DataProvider provider = new DataProvider();
        IFirebaseClient client = DataProvider.Instance.connect();
        #endregion

        #region Declare customer
        private customer Customer()
        {
            customer customer = new customer
            {
                name = textBox_customerName.Text,
                dOb = dateTimePicker_dOb.Text,
                address = textBox_customer_address.Text,
                CMND = textBox_customer_CMND.Text,
                phoneNum = textBox_customer_phoneNum.Text,
                nationality = textBox_customer_nationality.Text
            };
            return customer;
        }
        #endregion

        #region Reload DataGridView
        private void Reload()
        {
            var data = client.Get("/Customers");
            var mList = JsonConvert.DeserializeObject<IDictionary<string, customer>>(data.Body);
            var listCus = mList.Select(cus => new
            {
                name = cus.Value.name,
                dOb = cus.Value.dOb,
                addr = cus.Value.address,
                cmnd = cus.Value.CMND,
                phone =  cus.Value.phoneNum
            }).ToList();
            dataGridView_customerView.DataSource = listCus;
            dataGridView_customerView.AutoResizeColumns();
            if (dataGridView_customerView != null)
            {
                for (int count = 0; (count <= (dataGridView_customerView.Rows.Count - 1)); count++)
                {
                    dataGridView_customerView.Rows[count].HeaderCell.Value = string.Format((count + 1).ToString(), "0");
                }
            }

            #region Columns Rename
            this.dataGridView_customerView.Columns[0].HeaderText = "Tên KH";
            this.dataGridView_customerView.Columns[1].HeaderText = "Ngày sinh";
            this.dataGridView_customerView.Columns[2].HeaderText = "Địa chỉ";
            this.dataGridView_customerView.Columns[3].HeaderText = "CMND";
            this.dataGridView_customerView.Columns[4].HeaderText = "SĐT";
        }
            #endregion

        #endregion

        #region CRUD

        #region CLASS
        #region Add
        private void Add()
        {
            Customer();
            DialogResult dr = MessageBox.Show("Xác nhận thêm thông tin khách hàng?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                SetResponse set = client.Set("Customers/" + textBox_customer_CMND.Text, Customer());
                if (set.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Khách hàng [" + textBox_customerName.Text + "] đã được thêm thành công!!", "Thông báo!");                
                }
                else
                {
                    MessageBox.Show("Lỗi khi tạo tài khoản", "Lỗi");
                }
            }
        }
        #endregion
        #region Update
        private void Update_Cus()
        {
            Customer();
            DialogResult dr = MessageBox.Show("Xác nhận cập nhật tài khoản [" + textBox_customerName.Text + "] ", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                var update = client.Update("Customers/" + textBox_customer_CMND.Text, Customer());
            }
        }
        #endregion
        #region Delete
        private void Delete()
        {
            Customer();
            DialogResult dr = MessageBox.Show("Xác nhận xoá khách hàng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                var dlt = client.Delete(@"Customers/" + textBox_customer_CMND.Text);
                if (dlt.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Khách hàng [" + textBox_customerName.Text + "] đã được xoá thành công!", "Thông báo!");
                }
                else
                {
                    MessageBox.Show("Lỗi khi xoá khách hàng" + textBox_customerName.Text, "Thông báo!");
                }
            }
        }
        #endregion
        #endregion

        #region add
        private void button_addRoom_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = client.Get(@"Customers/" + textBox_customerName.Text);
            customer ResCus = res.ResultAs<customer>();
            customer CurCus = new customer()
            {
                CMND = textBox_customer_CMND.Text
            };
            if (customer.compare(ResCus, CurCus))
            {
                MessageBox.Show("Khách hàng đã tồn tại, xin vui lòng nhập lại!", "Thông báo");
            }
            else
            {
                Add();
                Reload();
            }
        }
        #endregion
        #region update
        private void button_updateRoom_Click(object sender, EventArgs e)
        {
            Update_Cus();
            Reload();
        }
        #endregion
        #region delete
        private void button_deleteRoom_Click(object sender, EventArgs e)
        {
            Delete();
            Reload();
        }
        #endregion

        #endregion

        #region Form Load Class
        private void Form_Customers_Load(object sender, EventArgs e)
        {
            Reload();
        }
        #endregion

        #region Show data to textBoxes
        private void dataGridView_customerView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = this.dataGridView_customerView.CurrentRow.Cells[3].Value.ToString();
            var data = client.Get(@"/Customers");
            var converted_data = JsonConvert.DeserializeObject<IDictionary<string, customer>>(data.Body);
            var r = converted_data.Single(t => t.Value.CMND.Equals(ID));

            #region Show
            this.textBox_customerName.Text = r.Value.name.ToString();
            this.dateTimePicker_dOb.Text =  r.Value.dOb.ToString();
            this.textBox_customer_CMND.Text = r.Value.CMND.ToString();
            this.textBox_customer_address.Text = r.Value.address.ToString();
            this.textBox_customer_phoneNum.Text = r.Value.phoneNum.ToString();
            this.textBox_customer_nationality.Text = r.Value.nationality.ToString();
            #endregion
        }
        #endregion
    }
}