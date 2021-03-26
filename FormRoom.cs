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
    public partial class FormRoom : Form
    {
        form_signin fs;
        public FormRoom(form_signin fsin)
        {
            InitializeComponent();
            this.fs = fsin;
        }
     
    #region IFirebase Config
        DataProvider provider = new DataProvider();
        IFirebaseClient client = DataProvider.Instance.connect();
    #endregion

    #region Button Account Manager
        private void button_accManager_Click(object sender, EventArgs e)
        {
            string name = fs.getUsername();
            FirebaseResponse res = client.Get(@"Users/" + name);
            User ResUser = res.ResultAs<User>();
            if (ResUser.role == "Admin")
            {
                FormAccountList fal = new FormAccountList();
                fal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chỉ admin mới có quyền xem", "Thông báo");
            }
            
        }
    #endregion

        private void button_modifyRoom_Click(object sender, EventArgs e)
        {
                        string name = fs.getUsername();
            FirebaseResponse res = client.Get(@"Users/" + name);
            User ResUser = res.ResultAs<User>();
            if (ResUser.role == "Admin")
            {
                Form_ModifyRoom fm = new Form_ModifyRoom();
                fm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chỉ admin mới có quyền xem", "Thông báo");
            }
        }

        #region Customers
        private void button_customers_Click(object sender, EventArgs e)
        {
            Form_Customers fs = new Form_Customers();
            fs.ShowDialog();
        }
        #endregion

    }
}
