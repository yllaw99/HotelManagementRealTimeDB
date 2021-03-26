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
                phone =  cus.Value.phoneNum,
                nationality = cus.Value.nationality
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
            this.dataGridView_customerView.Columns[5].HeaderText = "Quốc tịch";
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
                SetResponse set = client.Set("Customers/" + textBox_customerName.Text, Customer());
                if (set.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Khách hàng +[" + textBox_customerName.Text + "] đã được thêm thành công!!", "Thông báo!");                
                }
                else
                {
                    MessageBox.Show("Lỗi khi tạo tài khoản", "Lỗi");
                }
            }
        }
        #endregion
        #region Update
        private void Update()
        {

        }
        #endregion
        #region Delete
        private void Delete()
        {

        }
        #endregion
        #endregion

        #region add
        private void button_addRoom_Click(object sender, EventArgs e)
        {
            Add();
            Reload();
        }
        #endregion
        #region update
        private void button_updateRoom_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region delete
        private void button_deleteRoom_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void Form_Customers_Load(object sender, EventArgs e)
        {
            Reload();
        }

        #endregion
    }
}
