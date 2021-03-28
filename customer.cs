using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_FireBase
{
    class customer
    {
        public string name { get; set; }
        public string dOb { get; set; }
        public string address { get; set; }
        public string CMND { get; set; }
        public string phoneNum { get; set; }
        public string nationality { get; set; }

        #region compare
        public static bool compare(customer cus1, customer cus2)
        {
            if (cus1 == null || cus2 == null) { return false; }

            if (cus1.CMND != cus2.CMND)
            {
                return false;
            }
            return true;
        }
        #endregion
    }
}
