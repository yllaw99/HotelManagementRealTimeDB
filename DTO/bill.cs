using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_FireBase
{
    class Bill
    {
        //public Bill(string roomID, string dateCheckIn, string dateCheckOut, string stt, string bID, string Cusname)
        //{
        //    this.RoomID = roomID;
        //    this.DCheckIn = dateCheckIn;
        //    this.DCheckOut = dateCheckOut;
        //    this.Status = stt;
        //    this.BillID = bID;
        //    this.CusName = CusName;
        //}

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string cMND;

        public string CMND
        {
            get { return cMND; }
            set { cMND = value; }
        }

        private string cusName;

        public string CusName
        {
            get { return cusName; }
            set { cusName = value; }
        }

        private string billID;

        public string BillID
        {
            get { return billID; }
            set { billID = value; }
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private string dCheckIn;

        public string DCheckIn
        {
            get { return dCheckIn; }
            set { dCheckIn = value; }
        }

        private string dCheckOut;

        public string DCheckOut
        {
            get { return dCheckOut; }
            set { dCheckOut = value; }
        }

        private string roomID;

        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }
    }
}
