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
    public partial class form_signin : Form
    {
        public form_signin()
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
        private void form_signin_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Lỗi kết nối", "Cảnh báo!");
            }
        }
        #endregion Form Load

        #region Sign In
        private void button_signin_Click(object sender, EventArgs e)
        {
            #region Null Checking
            if (string.IsNullOrWhiteSpace(textBox_signin_username.Text) &&
               string.IsNullOrWhiteSpace(textBox_signin_pwd.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo!");
                return;
            }
            #endregion

            FirebaseResponse res = client.Get(@"Users/" + textBox_signin_username.Text);
            User ResUser = res.ResultAs<User>();
            User CurUser = new User()
            {
                username = textBox_signin_username.Text,
                pwd = textBox_signin_pwd.Text
            };
            if (User.IsEqual(ResUser, CurUser))
            {
                this.Hide();
                FormManager fm = new FormManager();
                fm.ShowDialog();
                this.Show();
                this.textBox_signin_pwd.Clear();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
        #endregion

    }
}
