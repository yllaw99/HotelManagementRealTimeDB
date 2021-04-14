using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_FireBase
{
    class Room
    {
        #region Declaration
        public string iD { get; set; }
        public string type { get; set; }
        public string status { get; set; }
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