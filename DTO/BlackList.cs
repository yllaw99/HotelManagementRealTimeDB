using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_FireBase.DTO
{
    class BlackList
    {
        private string identityId;

        public string IdentityId
        {
            get { return identityId; }
            set { identityId = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string nationality;

        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }

        private string phoneNum;

        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string note;

        public string Note
        {
            get { return note; }
            set { note = value; }
        }

    }
}
