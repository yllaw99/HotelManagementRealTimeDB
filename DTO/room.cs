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
        public string ID { get; set; }
        public string type { get; set; }
        public string status { get; set; }

        private string dateCheckIn;
        public string DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
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

            if (room1.ID != room2.ID)
            {
                return false;
            }
            return true;
        }
        #endregion
    }
}