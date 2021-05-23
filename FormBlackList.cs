#region imports
using FireSharp.Interfaces;
using FireSharp.Response;
using HotelManagement_FireBase.DAO;
using HotelManagement_FireBase.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace HotelManagement_FireBase
{
    public partial class FormBlackList : Form
    {
        public FormBlackList()
        {
            InitializeComponent();
        }

        #region connection
        DataProvider provider = new DataProvider();
        IFirebaseClient client = DataProvider.Instance.connect();
        #endregion

        #region declareBlackList
        private BlackList blackList()
        {
            BlackList listOfBadCustomer = new BlackList()
            {
                IdentityId = this.textBox_identityId.Text,
                Name = this.textBox_customerName.Text,
                Address = this.textBox_address.Text,
                Nationality = this.textBox_nationality.Text,
                PhoneNum = this.textBox_phoneNumber.Text,
                Note = this.textBox_note.Text
            };
            return listOfBadCustomer;
        }
        #endregion

        #region clickEvents

        private void button_add_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Get("BlackList/" + textBox_identityId.Text);

            BlackList responsedBlackList = response.ResultAs<BlackList>();

            BlackList currentBlackList = new BlackList()
            {
                IdentityId = textBox_identityId.Text
            };

            if (customerValidation(responsedBlackList, currentBlackList))

                MessageBox.Show("Đối tượng đã tồn tại, xin vui lòng nhập lại chính xác!", "Thông báo");

            else addNewBadCustomer();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            updateBadCustomerInfo();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            deleteBadCustomer();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox_identityId.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();

            this.textBox_customerName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();

            this.textBox_phoneNumber.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();

            this.textBox_address.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();

            this.textBox_nationality.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();

            this.textBox_note.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region loadMethods
        private void formLoad(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void loadDataGridView()
        {

            clearTextBoxes();

            getDataToDataGridView();

            setColumnProperties();

            setAutoIncreaseForIdColumn();

        }
        #endregion

        #region meThods

        private void setAutoIncreaseForIdColumn()
        {
            if (dataGridView != null)
            {
                for (int count = 0; (count <= (dataGridView.Rows.Count - 1)); count++)
                {
                    dataGridView.Rows[count].HeaderCell.Value = string.Format((count + 1).ToString(), "0");
                }
            }
        }

        private void getDataToDataGridView()
        {
            try
            {
                var data = client.Get("BlackList/");

                var convertedList = JsonConvert.DeserializeObject<IDictionary<string, BlackList>>(data.Body);

                var listOfBadCustomer = convertedList.Select(r => new
                {
                    id = r.Key,
                    fullName = r.Value.Name,
                    phoneNumber = r.Value.PhoneNum,
                    address = r.Value.Address,
                    nationality = r.Value.Nationality,
                    note = r.Value.Note
                }).ToList();
                dataGridView.DataSource = listOfBadCustomer;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi mạng, vui lòng xem kết nói  mạng và thử lại");
            }
        }

        private void setColumnProperties()
        {
            this.dataGridView.Columns[0].HeaderText = "CMND";
            this.dataGridView.Columns[1].HeaderText = "Họ và tên";
            this.dataGridView.Columns[2].HeaderText = "SĐT";
            this.dataGridView.Columns[3].HeaderText = "Địa chỉ";
            this.dataGridView.Columns[4].HeaderText = "Quốc tịch";
            this.dataGridView.Columns[5].HeaderText = "Ghi chú";
        }

        private void clearTextBoxes()
        {
            this.textBox_address.Clear();
            this.textBox_customerName.Clear();
            this.textBox_identityId.Clear();
            this.textBox_nationality.Clear();
            this.textBox_note.Clear();
            this.textBox_phoneNumber.Clear();
        }

        private bool customerValidation(BlackList blackList1, BlackList blackList2)
        {

            if (blackList1 == null || blackList2 == null) return false;

            if (blackList1.IdentityId != blackList2.IdentityId) return false;
            else return true;
        }

        #endregion

        #region CRUD methods

        private void addNewBadCustomer()
        {
            DialogResult dr = MessageBox.Show("Xác nhận thêm và danh sách?", "Thông báo!", MessageBoxButtons.YesNo);

            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                SetResponse set = client.Set("BlackList/" + textBox_identityId.Text, blackList());

                if (set.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("[" + textBox_customerName.Text + "] đã được thêm vào BlackList thành công!", "Thông báo!");

                    loadDataGridView();
                }

                else MessageBox.Show("Lỗi khi thêm [" + textBox_customerName.Text + "] vào BlackList", "Thông báo!");
            }
        }

        private void updateBadCustomerInfo()
        {
            try
            {
                DialogResult dr = MessageBox.Show("Xác nhận cập nhật?", "Thông báo!", MessageBoxButtons.YesNo);

                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    var update = client.Update("BlackList/" + textBox_identityId.Text, blackList());

                    if (update.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo!");

                        loadDataGridView();
                    }
                        
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void deleteBadCustomer()
        {
            DialogResult dr = MessageBox.Show("Xác nhận xoá ?", "Xác nhận", MessageBoxButtons.YesNo);

            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                var dlt = client.Delete("BlackList/" + textBox_identityId.Text);

                if (dlt.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Xoá thành công!", "Thông báo!");

                    loadDataGridView();
                }
                    
                else MessageBox.Show("Lỗi khi xoá", "Thông báo!");
            }
        }

        #endregion




    }
}
