using FireSharp.Interfaces;
using HotelManagement_FireBase.DAO;
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

namespace HotelManagement_FireBase
{
    public partial class FormBillManager : Form
    {
        #region connection
        DataProvider provider = new DataProvider();
        IFirebaseClient client = DataProvider.Instance.connect();
        #endregion

        #region formInit
        public FormBillManager()
        {
            InitializeComponent();
        }
        #endregion


        #region clickEvents
        private void label_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region methods
        private void loadDataGridView()
        {
            getData();
            setColumnProperties();
            
        }

        private void getData()
        {
            try
            {
                var data = client.Get("Bills/");
                var convertedList = JsonConvert.DeserializeObject<IDictionary<string, Bill>>(data.Body);
                var listOfBill = convertedList.Select(r => new
                {
                    roomId = r.Value.RoomID,                    
                    cusName = r.Value.CusName,
                    cmnd = r.Value.CMND,
                    contact = r.Value.Contact,
                    address = r.Value.Address,
                    status = r.Value.Status,
                    dCheckIn = r.Value.DCheckIn,
                    dCheckOut = r.Value.DCheckOut
                }).ToList();
                dataGridView.DataSource = listOfBill;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi mạng, vui lòng xem kết nói  mạng và thử lại");
            }
        }

        private void setColumnProperties()
        {
            this.dataGridView.Columns[0].HeaderText = "Mã phòng";
            this.dataGridView.Columns[1].HeaderText = "Họ và tên";
            this.dataGridView.Columns[2].HeaderText = "CMND";
            this.dataGridView.Columns[3].HeaderText = "Liên lạc";
            this.dataGridView.Columns[4].HeaderText = "Địa chỉ";
            this.dataGridView.Columns[5].HeaderText = "Trạng thái";
            this.dataGridView.Columns[6].HeaderText = "Ngày check-in";
            this.dataGridView.Columns[7].HeaderText = "Ngày check-out";
        }
        #endregion

        #region formLoad
        private void FormBillManager_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }
        #endregion
    }
}
