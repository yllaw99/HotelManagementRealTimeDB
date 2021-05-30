using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_FireBase
{
    public class Bill
    {
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

        private string cardExpDate;
        public string CardExpDate
        {
            get { return cardExpDate; }
            set { cardExpDate = value; }
        }

        private string contact;
        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        private string creditCardID;
        public string CreditCardID
        {
            get { return creditCardID; }
            set { creditCardID = value; }
        }

        private string cusName;
        public string CusName
        {
            get { return cusName; }
            set { cusName = value; }
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

        private string payment;
        public string Payment
        {
            get { return payment; }
            set { payment = value; }
        }

        private string reservationType;
        public string ReservationType
        {
            get { return reservationType; }
            set { reservationType = value; }
        }

        private string total;
        public string Total
        {
            get { return total; }
            set { total = value; }
        }

        private string voucherUsed;
        public string VoucherUsed
        {
            get { return voucherUsed; }
            set { voucherUsed = value; }
        }
    }
}
