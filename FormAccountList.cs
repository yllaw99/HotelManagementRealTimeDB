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

        #region Form Load
        private void FormAccountList_Load(object sender, EventArgs e)
        {
            DataGridView_LoadContent();
        }
        #endregion

        #region Load Content to DataGridView
        private void DataGridView_LoadContent()
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
            var listNumber = mList.Select(tk => new
            {
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

        #region Display AccInfo in TextBox
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
            this.comboBox_accInfo_gender.Text = us.Value.gender.ToString();
            this.comboBox_accInfo_role.Text = us.Value.role.ToString();
            #endregion
        }
        #endregion

        #region CRUD
        #region Add Account
        private void button_add_account_Click(object sender, EventArgs e)
        {
            // Checking if user has already been existed
            FirebaseResponse res = client.Get(@"Users/" + textBox_accInfo_username.Text);
            User ResUser = res.ResultAs<User>();
            User CurUser = new User()
            {
                username = textBox_accInfo_username.Text
            };
            if (User.compare(ResUser, CurUser))
            {
                MessageBox.Show("Tài khoản đã tồn tại, xin vui lòng nhập username khác!", "Thông báo");
            }
            else
            {
                Add();
            }
        }
        #endregion
        #region Delete Account
        private void button_acc_del_Click(object sender, EventArgs e)
        {
            Delete();            
        }
        #endregion
        #region Update Account
        private void button_acc_update_Click(object sender, EventArgs e)
        {
            Update_acc();
        }
        #endregion

        #region ClassDeclare User
        private User Declare()
        {
            User user = new User()
            {
                username = textBox_accInfo_username.Text,
                pwd = textBox_accInfo_pwd.Text,
                fullname = textBox_accInfo_fullname.Text,
                phoneNum = textBox_accInfo_phonenum.Text,
                gender = comboBox_accInfo_gender.Text,
                role = comboBox_accInfo_role.Text
            };
            return user;
        }
        #endregion

        #region ClassDelete
        private void Delete()
        {
            Declare();
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                var dlt = client.Delete(@"Users/" + textBox_accInfo_username.Text);
                if(dlt.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Tài khoản [" + textBox_accInfo_username.Text + "] đã được xoá thành công!", "Thông báo!");
                }
                else
                {
                    MessageBox.Show("Lỗi khi xoá tài khoản" + textBox_accInfo_username.Text, "Thông báo!");
                }
                DataGridView_LoadContent();
            }
        }
        #endregion
        #region ClassAdd
        private void Add()
        {
            Declare();
            DialogResult dr = MessageBox.Show("Xác nhận thêm tài khoản?", "Thông báo!", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                SetResponse set = client.Set(@"Users/" + textBox_accInfo_username.Text, Declare());
                if (set.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Tài khoản [" + textBox_accInfo_username.Text + "] đã được tạo thành công!", "Thông báo!");
                }
                else
                {
                    MessageBox.Show("Lỗi khi tạo tài khoản [" + textBox_accInfo_username.Text + "]", "Thông báo!");
                }
                DataGridView_LoadContent();
            }
        }
        #endregion
        #region ClassUpdate
        private void Update_acc()
        {
            try
            {
                Declare();
                DialogResult dr = MessageBox.Show("Xác nhận cập nhật tài khoản?", "Thông báo!", MessageBoxButtons.YesNo);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    var update = client.Update(@"Users/" + textBox_accInfo_username.Text, Declare());
                    if (update.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Tài khoản [" + textBox_accInfo_username.Text + "] đã được cập nhật thành công!", "Thông báo!");
                        DataGridView_LoadContent();
                    }
                    
                }                
            }
            catch
            {
                MessageBox.Show("Loi khi cap nhat tai khoan");
            }
        }
        #endregion

        #endregion

    }
}
