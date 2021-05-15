using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_FireBase.DTO
{
    public class promo
    {
        private string vip;
        public string Vip
        {
            get { return vip; }
            set { vip = value; }
        }

        private string voucher;
        public string Voucher
        {
            get { return voucher; }
            set { voucher = value; }
        }
    }
}
