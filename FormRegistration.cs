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


namespace HotelManagement_FireBase
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        #region IFirebaseConfig
        IFirebaseConfig ifc = new FirebaseConfig
        {
            AuthSecret = "ajFr4H1tKZefLtJPRja8HyG1uc58m9DhQr8sO8MO",
            BasePath = "https://hotelmanagement-dd391-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        #endregion

        #region Form_Registration_Load
        private void Form_Registration_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
                comboBox_gender.Items.Add("Nam");
                comboBox_gender.Items.Add("Nữ");
                comboBox_gender.Items.Add("Khác");
            }

            catch
            {
                MessageBox.Show("Lỗi kết nối", "Cảnh báo!");
            }
        }
        #endregion

        #region Add new User
        private void button_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_signup_username.Text) ||
                string.IsNullOrWhiteSpace(textBox_signup_pwd.Text) ||
                string.IsNullOrWhiteSpace(textBox__signup_repwd.Text) ||
                string.IsNullOrEmpty(comboBox_gender.Text) ||
                string.IsNullOrWhiteSpace(textBox_signup_fullname.Text) ||
                string.IsNullOrWhiteSpace(textBox_signup_phonenum.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin","Thông báo!");
                return;
            }

            User user = new User
            {
                username = textBox_signup_username.Text,
                pwd = textBox_signup_pwd.Text,
                fullname = textBox_signup_fullname.Text,
                gender = comboBox_gender.GetItemText(this.comboBox_gender.Text),
                phoneNum = textBox_signup_phonenum.Text
            };
            SetResponse set = client.Set(@"/Users/" + user.username, user);
            if(set.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(string.Format(@"Successfully registered {0}!", "Information!"),textBox_signup_username.Text);
            }
            else
            {
                MessageBox.Show("Registered failed!");
            }
        }
        #endregion

        #region Delete Form Text
        private void button_delete_Click(object sender, EventArgs e)
        {
            textBox_signup_username.Clear();
            textBox_signup_pwd.Clear();
            textBox__signup_repwd.Clear();
            textBox_signup_fullname.Clear();
            textBox_signup_phonenum.Clear();

        }
        #endregion
    }
}
