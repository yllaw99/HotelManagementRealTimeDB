#region import things
using FireSharp.Interfaces;
using FireSharp.Response;
using HotelManagement_FireBase.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
#endregion

namespace HotelManagement_FireBase
{
    public partial class FormBill : Form
    {
        FormRoom fr;
        #region connect to db
        DataProvider provider = new DataProvider();
        IFirebaseClient client = DataProvider.Instance.connect();
        #endregion
        public FormBill(FormRoom frm)
        {
            InitializeComponent();
            this.fr = frm;
        }

        #region Load Form
        private void FormBill_Load(object sender, EventArgs e)
        {
            this.label_roomID.Text = fr.rID;

        }
        #endregion

        #region Function
        void getData(string roomID) //input = RoomID //output = BillInfo
        {
            FirebaseResponse data = client.Get("Bills/" + roomID);
            IDictionary<string, Bill> billInfo = JsonConvert.DeserializeObject<IDictionary<string, Bill>>(data.Body);
        }
        #endregion

    }
}
