using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement_FireBase.DAO;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Newtonsoft.Json;


namespace HotelManagement_FireBase
{
    public partial class Form_ModifyRoom : Form
    {
        public Form_ModifyRoom()
        {
            InitializeComponent();
        }

        #region connect to db
        DataProvider provider = new DataProvider();
        IFirebaseClient client = DataProvider.Instance.connect();
        #endregion

        #region Declare Room
        private Room Declare_room()
        {
            Room room = new Room
            {
                ID = textBox_roomID.Text,
                type = comboBox_roomType.Text,
                price = textBox_roomPrice.Text,
                status = comboBox_roomStt.Text
            };
            return room;
        }
        #endregion

        #region Form Load
        private void Form_ModifyRoom_Load(object sender, EventArgs e)
        {
            DataGridView_LoadContent();
        }
        #endregion

        #region dataGridView Cell Click
        private void dataGridView_roomView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = this.dataGridView_roomView.CurrentRow.Cells[0].Value.ToString();
            var data = client.Get(@"/Rooms");
            var converted_data = JsonConvert.DeserializeObject<IDictionary<string, Room>>(data.Body);
            var r = converted_data.Single(t => t.Value.ID.Equals(ID));

            #region Show
            this.textBox_roomID.Text = r.Value.ID.ToString();
            this.textBox_roomPrice.Text = r.Value.price.ToString();
            this.comboBox_roomType.Text = r.Value.type.ToString();
            this.comboBox_roomStt.Text = r.Value.status.ToString();
        }
        #endregion
    
        #region Load Content to DataGridView CLASS
        private void DataGridView_LoadContent()
        {
            var data = client.Get("/Rooms");
            var mList = JsonConvert.DeserializeObject<IDictionary<string, Room>>(data.Body);
            var listNumber = mList.Select(r => new
            {
                ID = r.Value.ID,
                Type = r.Value.type,
                Price = r.Value.price,
                Status = r.Value.status
            }).ToList();
            dataGridView_roomView.DataSource = listNumber;
            dataGridView_roomView.AutoResizeColumns();
            if (dataGridView_roomView != null)
            {
                for (int count = 0; (count <= (dataGridView_roomView.Rows.Count - 1)); count++)
                {
                    dataGridView_roomView.Rows[count].HeaderCell.Value = string.Format((count + 1).ToString(), "0");
                }
            }
            this.dataGridView_roomView.Columns[0].HeaderText = "ID";
            this.dataGridView_roomView.Columns[1].HeaderText = "Loại phòng";
            this.dataGridView_roomView.Columns[2].HeaderText = "Giá phòng";
            this.dataGridView_roomView.Columns[3].HeaderText = "Trạng thái";
        }
        #endregion

        #endregion


        #region ClassDelete
        private void Delete()
        {
            Declare_room();
            DialogResult dr = MessageBox.Show("Xác nhận xoá phòng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                var dlt = client.Delete(@"Rooms/" + textBox_roomID.Text);
                if (dlt.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Phòng [" + textBox_roomID.Text + "] đã được xoá thành công!", "Thông báo!");
                }
                else
                {
                    MessageBox.Show("Lỗi khi xoá phòng" + textBox_roomID.Text, "Thông báo!");
                }
                //DataGridView_LoadContent();
            }
        }
        #endregion
        #region ClassAdd
        private void Add()
        {
            Declare_room();
            DialogResult dr = MessageBox.Show("Xác nhận thêm phòng?", "Thông báo!", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                SetResponse set = client.Set(@"Rooms/" + textBox_roomID.Text, Declare_room());
                if (set.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Phòng [" + textBox_roomID.Text + "] đã được tạo thành công!", "Thông báo!");
                }
                else
                {
                    MessageBox.Show("Lỗi khi tạo phòng [" + textBox_roomID.Text + "]", "Thông báo!");
                }
                //DataGridView_LoadContent();
            }
        }
        #endregion
        #region ClassUpdate
        private void Update()
        {
            try
            {
                Declare_room();
                DialogResult dr = MessageBox.Show("Xác nhận cập nhật phòng?", "Thông báo!", MessageBoxButtons.YesNo);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    var update = client.Update(@"Rooms/" + textBox_roomID.Text, Declare_room());
                    if (update.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Phòng [" + textBox_roomID.Text + "] đã được cập nhật thành công!", "Thông báo!");
                        //dataGridView_roomView();
                    }

                }
            }
            catch
            {
                MessageBox.Show("Loi khi cap nhat tai khoan");
            }
        }
        #endregion

        #region CRUD
        #region Add new Room
        private void button_addRoom_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = client.Get(@"Rooms/" + textBox_roomID.Text);
            Room ResRoom = res.ResultAs<Room>();
            Room CurRoom = new Room()
            {
                ID = textBox_roomID.Text
            };
            if (Room.compare(ResRoom, CurRoom))
            {
                MessageBox.Show("Phòng đã tồn tại, xin vui lòng nhập ID phòng khác!", "Thông báo");
            }
            else
            {
                Add();
                DataGridView_LoadContent();
            }
            
        }
        #endregion

        #region Update room
        private void button_updateRoom_Click(object sender, EventArgs e)
        {
            Update();
            DataGridView_LoadContent();
        }
        #endregion

        #region Delete Room
        private void button_deleteRoom_Click(object sender, EventArgs e)
        {
            Delete();
            DataGridView_LoadContent();
        }
        #endregion

        



        #endregion


    }
}
