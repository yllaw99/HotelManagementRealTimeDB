#region Import things
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
#endregion

namespace HotelManagement_FireBase
{
    public partial class FormRoom : Form
    {
        form_signin fs;
        public FormRoom(form_signin fsin)
        {
            InitializeComponent();
            this.fs = fsin;
            LoadRoom();
        }

        #region btn_click_event
        void btn_Click(object sender, EventArgs e)
        {
            //if()
            show_reservation();
        }

        void show_reservation()
        {
            FormReservation fr = new FormReservation();
            fr.ShowDialog();
        }

        void show_bill()
        {
            FormBill fb = new FormBill();
            fb.ShowDialog();
        }
        #endregion

        #region Display rooms
        roomDAO rDAO = new roomDAO();
        public void LoadRoom()
        {
            FirebaseResponse response = client.Get("Rooms/");
            IDictionary<string, Room> rList = JsonConvert.DeserializeObject<IDictionary<string, Room>>(response.Body);

            foreach (var r in rList)
            {
                Button btn = new Button() { Width = roomDAO.width, Height = roomDAO.height };
                flowLayoutPanel1.Controls.Add(btn);
                btn.Text = "Phòng " + r.Key.ToString() + "\n\n" + r.Value.status.ToString();
                btn.Click += btn_Click;
                switch (r.Value.status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.AntiqueWhite;
                        break;
                }
            }            
        }
        #endregion
        #region IFirebase Config
        DataProvider provider = new DataProvider();
        IFirebaseClient client = DataProvider.Instance.connect();
        #endregion

        #region Button Account Manager
        private void button_accManager_Click(object sender, EventArgs e)
        {
            string name = fs.getUsername();
            FirebaseResponse res = client.Get("Users/" + name);
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

        #region Button modify click
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
        #endregion

        #region Customers
        private void button_customers_Click(object sender, EventArgs e)
        {
            Form_Customers fs = new Form_Customers();
            fs.ShowDialog();
        }
        #endregion

    }
}
