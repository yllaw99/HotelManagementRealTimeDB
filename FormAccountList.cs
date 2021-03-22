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
using Newtonsoft.Json;

namespace HotelManagement_FireBase
{
    public partial class FormAccountList : Form
    {
        public FormAccountList()
        {
            InitializeComponent();
        }
        #region IFirebase Config
        IFirebaseConfig ifc = new FirebaseConfig
        {
            AuthSecret = "ajFr4H1tKZefLtJPRja8HyG1uc58m9DhQr8sO8MO",
            BasePath = "https://hotelmanagement-dd391-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        #endregion

        #region Add Account
        private void button_add_account_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistration fr = new FormRegistration();
            fr.ShowDialog();
            this.Show();
        }
        #endregion

        #region Form Load
        private void FormAccountList_Load(object sender, EventArgs e)
        {
            #region Connect
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Lỗi kết nối", "Cảnh báo!");
            }
            #endregion
            var data = client.Get("/Users");
            var mList = JsonConvert.DeserializeObject<IDictionary<string, User>>(data.Body);
            var listNumber = mList.Select(tk => new { 
                name = tk.Value.fullname,
                username = tk.Value.username
            }).ToList();
            dataGridView_accInfo.DataSource = listNumber;
            dataGridView_accInfo.AutoResizeColumns();
            if (dataGridView_accInfo != null)
            {
                for (int count = 0; (count <= (dataGridView_accInfo.Rows.Count - 2)); count++)
                {
                    dataGridView_accInfo.Rows[count].HeaderCell.Value = string.Format((count + 1).ToString(), "0");
                }
            }
            this.dataGridView_accInfo.Columns[0].HeaderText = "Họ và tên";
            this.dataGridView_accInfo.Columns[1].HeaderText = "Tên tài khoản";
        }
        #endregion

        #region Display AccInfo
        private void dataGridView_accInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string usernameLocal = this.dataGridView_accInfo.CurrentRow.Cells[1].Value.ToString();
            var data = client.Get(@"/Users");
            var converted_data = JsonConvert.DeserializeObject<IDictionary<string, User>>(data.Body);
            var us = converted_data.Single(t => t.Value.username.Equals(usernameLocal));

            #region Show
            this.textBox_accInfo_fullname.Text = us.Value.fullname.ToString();
            this.textBox_accInfo_username.Text = us.Value.username.ToString();
            this.textBox_accInfo_pwd.Text = us.Value.pwd.ToString();
            this.textBox_accInfo_phonenum.Text = us.Value.phoneNum.ToString();
            this.textBox_accInfo_gender.Text = us.Value.gender.ToString();
            #endregion
        }
        #endregion

        private void button_acc_del_Click(object sender, EventArgs e)
        {
            string username = this.dataGridView_accInfo.CurrentRow.Cells[1].Value.ToString();
            var data = client.Get(@"/Users");
            var converted_data = JsonConvert.DeserializeObject<IDictionary<string, User>>(data.Body);
            var us = converted_data.Single(t => t.Value.username.Equals(username));

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                //User user = us.Value.username.Single => t.Value.username.Equals(username));
            }
        }
    }
}
