#region imports
using FireSharp.Interfaces;
using HotelManagement_FireBase.DAO;
using HotelManagement_FireBase.DTO;
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
                FullName = this.textBox_customerName.Text,
                Address = this.textBox_address.Text,
                Nationality = this.textBox_nationality.Text,
                PhoneNumber = this.textBox_phoneNumber.Text,
                Note = this.textBox_note.Text
            };
            return listOfBadCustomer;
        }
        #endregion




        #region clickEvents
        private void label_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        #endregion

        private void button_addRoom_Click(object sender, EventArgs e)
        {

        }

        private void formLoad(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void loadDataGridView()
        {
            
            throw new NotImplementedException();
        }
    }
}
