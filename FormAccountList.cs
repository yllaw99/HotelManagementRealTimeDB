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
using HotelManagement_FireBase.DAO;

namespace HotelManagement_FireBase
{
    public partial class FormAccountList : Form
    {
        public FormAccountList()
        {
            InitializeComponent();
        }
        #region connect to db
        DataProvider provider = new DataProvider();
        IFirebaseClient client = DataProvider.Instance.connect();
        #endregion

        #region Form Load
        private void FormAccountList_Load(object sender, EventArgs e)
        {
            Reload();
        }
        #endregion

        #region functions
        #region clear textboxes
        private void ClearTextboxes()
        {
            textBox_accInfo_fullname.Clear();
            textBox_accInfo_phonenum.Clear();
            textBox_accInfo_pwd.Clear();
            textBox_accInfo_username.Clear();

            comboBox_accInfo_gender.Items.Clear();
            comboBox_accInfo_role.Items.Clear();
        }
        #endregion
        #region reload
        private void Reload()
        {
            var data = client.Get("/Users");

            var mList = JsonConvert.DeserializeObject<IDictionary<string, User>>(data.Body);

            var listNumber = mList.Select(tk => new
            {
                name = tk.Value.fullname,

                username = tk.Value.username,

                role = tk.Value.role,

                phoneNumber = tk.Value.phoneNum,

                gender = tk.Value.gender
            }).ToList();
            dataGridView_accInfo.DataSource = listNumber;
            if (dataGridView_accInfo != null)
            {
                for (int count = 0; (count <= (dataGridView_accInfo.Rows.Count - 1)); count++)
                {
                    dataGridView_accInfo.Rows[count].HeaderCell.Value = string.Format((count + 1).ToString(), "0");
                }
            }
            this.dataGridView_accInfo.Columns[0].HeaderText = "Họ và tên";

            this.dataGridView_accInfo.Columns[1].HeaderText = "Tên tài khoản";

            this.dataGridView_accInfo.Columns[2].HeaderText = "Chức vụ";

            this.dataGridView_accInfo.Columns[3].HeaderText = "SĐT";

            this.dataGridView_accInfo.Columns[4].HeaderText = "Giới tính";
        }
        #endregion
        #endregion

        #region Display AccInfo in TextBox
        private void dataGridView_accInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox_accInfo_gender.Items.Add("Nam");

            comboBox_accInfo_gender.Items.Add("Nữ");

            comboBox_accInfo_gender.Items.Add("Khác");

            comboBox_accInfo_role.Items.Add("Nhân viên");

            comboBox_accInfo_role.Items.Add("Admin");

            this.textBox_accInfo_fullname.Text = dataGridView_accInfo.CurrentRow.Cells[0].Value.ToString();

            this.textBox_accInfo_username.Text = dataGridView_accInfo.CurrentRow.Cells[1].Value.ToString();

            this.textBox_accInfo_phonenum.Text = dataGridView_accInfo.CurrentRow.Cells[3].Value.ToString();

            this.comboBox_accInfo_gender.Text = dataGridView_accInfo.CurrentRow.Cells[4].Value.ToString();

            this.comboBox_accInfo_role.Text = dataGridView_accInfo.CurrentRow.Cells[2].Value.ToString();

            this.textBox_accInfo_pwd.Clear();

            this.textBoxGender.Text = comboBox_accInfo_gender.SelectedItem.ToString();

            this.textBoxRole.Text = comboBox_accInfo_role.SelectedItem.ToString();
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
                pwd = provider.hash_password(textBox_accInfo_pwd.Text),
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
                Reload();
                ClearTextboxes();
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
                Reload();
                ClearTextboxes();
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
                        Reload();
                        ClearTextboxes();
                    }
                    
                }                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #endregion

        private void dropDownGenderComboBox(object sender, EventArgs e)
        {
            this.comboBox_accInfo_gender.DroppedDown = true;
        }

        private void dropDownRoleComboBox(object sender, EventArgs e)
        {
            this.comboBox_accInfo_role.DroppedDown = true;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
