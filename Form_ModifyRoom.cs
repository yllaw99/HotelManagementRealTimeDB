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

        private bool roomTypeChecking;
        #region connect to db
        DataProvider provider = new DataProvider();
        IFirebaseClient client = DataProvider.Instance.connect();
        #endregion

        private bool isNull(string textBoxValue)
        {
            return string.IsNullOrWhiteSpace(textBoxValue);
        }

        #region Declare Room
        private Room Declare_room()
        {
            Room room = new Room()
            {
                ID = textBox_roomID.Text,
                type = textBox_roomType.Text,
                status = textBox_roomStt.Text,
                DateCheckIn = textBox_dateCheckIn.Text
            };
            return room;
        }
        #endregion

        #region Form Load
        private void Form_ModifyRoom_Load(object sender, EventArgs e)
        {

            loadDataToDataGridView();

        }
        #endregion

        #region dataGridView Cell Click
        private void dataGridView_roomView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox_roomID.Text = dataGridView_roomView.CurrentRow.Cells[0].Value.ToString();

            this.textBox_roomType.Text = dataGridView_roomView.CurrentRow.Cells[1].Value.ToString();

            this.textBox_roomStt.Text = dataGridView_roomView.CurrentRow.Cells[2].Value.ToString();

            this.textBox_dateCheckIn.Text = dataGridView_roomView.CurrentRow.Cells[3].Value.ToString();


        }
        #endregion

        #region Load Content to DataGridView CLASS
        private void loadDataToDataGridView()
        {
            this.textBox_roomID.Clear();
            this.textBox_roomType.Text = "";
            this.textBox_roomStt.Text = "";
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
                    MessageBox.Show("Phòng [" + textBox_roomID.Text + "] đã được xoá thành công!", "Thông báo!");
                else MessageBox.Show("Lỗi khi xoá phòng" + textBox_roomID.Text, "Thông báo!");
                loadDataToDataGridView();
            }
        }
        #endregion
        #region ClassAdd
        private void Add()
        {
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
                loadDataToDataGridView();
            }
        }
        #endregion
        #region ClassUpdate
        private void Update_()
        {
            try
            {
                DialogResult dr = MessageBox.Show("Xác nhận cập nhật phòng?", "Thông báo!", MessageBoxButtons.YesNo);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    var update = client.Update("Rooms/" + textBox_roomID.Text, Declare_room());
                    if (update.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Phòng [" + textBox_roomID.Text + "] đã được cập nhật thành công!", "Thông báo!");
                        loadDataToDataGridView();
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
            int parsedValue;
            roomTypeChecking = (!this.textBox_roomType.Text.Equals("Single Bed") && !this.textBox_roomType.Text.Equals("Double Bed") && !this.textBox_roomType.Text.Equals("Triple Bed") && !this.textBox_roomType.Text.Equals("Family"));
            FirebaseResponse res = client.Get(@"Rooms/" + textBox_roomID.Text);
            Room ResRoom = res.ResultAs<Room>();
            Room CurRoom = new Room()
            {
                ID = textBox_roomID.Text
            };
            if (Room.compare(ResRoom, CurRoom))MessageBox.Show("Phòng đã tồn tại, xin vui lòng nhập ID phòng khác!", "Thông báo");
            else
            {
                if (isNull(textBox_roomID.Text) || roomTypeChecking)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ và đúng thông tin", "Thông báo");
                    return;
                }
                else if (!int.TryParse(textBox_roomID.Text, out parsedValue))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số phòng");
                    return;
                }
                else Add();
            }
        }
        #endregion

        #region Update room
        private void button_updateRoom_Click(object sender, EventArgs e)
        {
            int parsedValue;
            roomTypeChecking = (!this.textBox_roomType.Text.Equals("Single Bed") && !this.textBox_roomType.Text.Equals("Double Bed") && !this.textBox_roomType.Text.Equals("Triple Bed") && !this.textBox_roomType.Text.Equals("Family"));
            if (isNull(textBox_roomID.Text) || roomTypeChecking)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo!");
                return;
            }
            else if (!int.TryParse(textBox_roomID.Text, out parsedValue))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số phòng");
                return;
            }
            else Update_();
        }
        #endregion

        #region Delete Room
        private void button_deleteRoom_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (isNull(textBox_roomID.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo!");
                return;
            }
            else if (!isNull(textBox_dateCheckIn.Text))
            {
                MessageBox.Show("Phòng đang có người hoặc đã được đặt", "Không thể xoá phòng");
            }
            else if (!int.TryParse(textBox_roomID.Text, out parsedValue))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số phòng");
                return;
            }
            else Delete();
        }
        #endregion

        #endregion

        #region get room status
        public string getRoomStatus()
        {
            return textBox_roomStt.Text;
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


    }
}
