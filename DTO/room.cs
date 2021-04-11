using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_FireBase
{
    public class Room
    {
        #region Declaration
        private string iD;

        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private string price;

        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion
        #region compare
        public static bool compare(Room room1, Room room2)
        {
            if (room1 == null || room2 == null) { return false; }

            if (room1.iD != room2.iD)
            {
                return false;
            }
            return true;
        }
        #endregion
    }
}