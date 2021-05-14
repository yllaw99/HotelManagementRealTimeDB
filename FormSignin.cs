﻿using System;
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
    public partial class form_signin : Form
    {
        #region initial
        public form_signin()
        {
            InitializeComponent();
        }
        #endregion
        #region connect to db
        DataProvider provider = new DataProvider();
        IFirebaseClient client = DataProvider.Instance.connect();
        #endregion

        public string getUsername()
        {
            return textBox_signin_username.Text;
        }

    #region Sign In
        private void button_signin_Click(object sender, EventArgs e)
        {
        #region Null Checking
            if (string.IsNullOrWhiteSpace(textBox_signin_username.Text) &&
               string.IsNullOrWhiteSpace(textBox123.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo!");
                return;
            }
        #endregion
            try
            {
                FirebaseResponse res = client.Get(@"Users/" + getUsername());
                User ResUser = res.ResultAs<User>();
                User CurUser = new User()
                {
                    username = getUsername(),
                    pwd = textBox123.Text
                };

                if (User.IsEqual(ResUser, CurUser))
                {
                    this.Hide();
                    FormRoom fr = new FormRoom(this);
                    fr.ShowDialog();
                    this.Show();
                    this.textBox123.Clear();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vui lòng thử lại", MessageBoxButtons.OK);
            }
            // check if username & pwd are correct
        }
        #endregion

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
