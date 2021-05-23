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
            Room room = new Room()
            {
                type = comboBox_roomType.Text,
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
            this.textBox_roomID.Text = dataGridView_roomView.CurrentRow.Cells[0].Value.ToString();

            this.comboBox_roomType.Text = dataGridView_roomView.CurrentRow.Cells[1].Value.ToString();

            this.roundedTextBoxRoomType.Text = comboBox_roomType.Text.ToString();

            this.comboBox_roomStt.Text = dataGridView_roomView.CurrentRow.Cells[2].Value.ToString();

            this.roundedTextboxRoomStt.Text = comboBox_roomStt.Text.ToString();

            this.textBox_dateCheckIn.Text = dataGridView_roomView.CurrentRow.Cells[3].Value.ToString();
        }
        #endregion
    
        #region Load Content to DataGridView CLASS
        private void DataGridView_LoadContent()
        {
            this.textBox_roomID.Clear();
            this.comboBox_roomType.Text = "";
            this.comboBox_roomStt.Text = "";
            this.textBox_dateCheckIn.Clear();

            var data = client.Get("Rooms/");
            var mList = JsonConvert.DeserializeObject<IDictionary<string, Room>>(data.Body);
            var listNumber = mList.Select(r => new
            {
                ID = r.Key,
                Type = r.Value.type,
                Status = r.Value.status,
                BillID = r.Value.DateCheckIn
            }).ToList();
            dataGridView_roomView.DataSource = listNumber;
            
            if (dataGridView_roomView != null)
            {
                for (int count = 0; (count <= (dataGridView_roomView.Rows.Count - 1)); count++)
                {
                    dataGridView_roomView.Rows[count].HeaderCell.Value = string.Format((count + 1).ToString(), "0");
                }
            }
            this.dataGridView_roomView.Columns[0].HeaderText = "ID";
            this.dataGridView_roomView.Columns[1].HeaderText = "Loại phòng";
            this.dataGridView_roomView.Columns[2].HeaderText = "Trạng thái";
            this.dataGridView_roomView.Columns[3].HeaderText = "Ngày CheckIn";
        }
        #endregion



        #region ClassDelete
        private void Delete()
        {
            DialogResult dr = MessageBox.Show("Xác nhận xoá phòng?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                var dlt = client.Delete(@"Rooms/" + textBox_roomID.Text);
                if (dlt.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Phòng [" + textBox_roomID.Text + "] đã được xoá thành công!", "Thông báo!");
                    //DataGridView_LoadContent();
                }
                else
                {
                    MessageBox.Show("Lỗi khi xoá phòng" + textBox_roomID.Text, "Thông báo!");
                }
                DataGridView_LoadContent();
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
            }
        }
        #endregion
        #region ClassUpdate
        private void Update_()
        {
            try
            {
                Declare_room();
                DialogResult dr = MessageBox.Show("Xác nhận cập nhật phòng?", "Thông báo!", MessageBoxButtons.YesNo);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    var update = client.Update("Rooms/" + textBox_roomID.Text, Declare_room());
                    if (update.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Phòng [" + textBox_roomID.Text + "] đã được cập nhật thành công!", "Thông báo!");
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
            Update_();
        }
        #endregion

        #region Delete Room
        private void button_deleteRoom_Click(object sender, EventArgs e)
        {
            Delete();
        }
        #endregion

        #endregion

        #region get room status
        public string getRoomStatus()
        {
            return comboBox_roomStt.Text;
        }
        #endregion

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel5_click(object sender, EventArgs e)
        {
            FormRoomTypePrice price = new FormRoomTypePrice();
            price.ShowDialog();
        }

        private void dropDownRoomType(object sender, EventArgs e)
        {
            this.comboBox_roomType.DroppedDown = true;
        }

        private void dropDownRoomStt(object sender, EventArgs e)
        {
            this.comboBox_roomStt.DroppedDown = true;
        }



    }
}
