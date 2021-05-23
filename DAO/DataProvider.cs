using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using HotelManagement_FireBase.DTO;

namespace HotelManagement_FireBase.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        public DataProvider() { }
        #region connect
        public IFirebaseClient connect()
        {
            IFirebaseConfig ifc = new FirebaseConfig
            {
                AuthSecret = "ajFr4H1tKZefLtJPRja8HyG1uc58m9DhQr8sO8MO",
                BasePath = "https://hotelmanagement-dd391-default-rtdb.firebaseio.com/"
            };
            IFirebaseClient client;
            client = new FireSharp.FirebaseClient(ifc);
            return client;
        }
        #endregion
        #region getIDBill
        public string GetIDBill(string rID)
        {
            IFirebaseClient client = this.connect();
            FirebaseResponse res = client.Get("/Bills" + rID);
            IDictionary<string, Bill> Bill_List = JsonConvert.DeserializeObject<IDictionary<string, Bill>>(res.Body);
            string billID = Bill_List.Select(b => new { bID = b.Value.BillID }).ToString();
            return billID;
        }
        #endregion
        #region get bill info
        public Bill getBillInfo(string dCheckIn, string roomID)
        {
            IFirebaseClient client = connect();
            FirebaseResponse data = client.Get("Bills/" + dCheckIn + "/" + roomID);
            Bill billInfo = data.ResultAs<Bill>();
            return billInfo;
        }
        #endregion
        #region getRoominfo
        public Room getRoomInfo(string roomID)
        {
            IFirebaseClient client = connect();
            FirebaseResponse data = client.Get("Rooms/" + roomID);
            Room roomInfo = data.ResultAs<Room>();
            return roomInfo;
        }
        #endregion
        #region encrypt pwd
        public string hash_password(string pure_pwd)
        {
            pure_pwd += "yllaw";
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] pwd_byte = Encoding.ASCII.GetBytes(pure_pwd);
            byte[] encrypted_byte = sha1.ComputeHash(pwd_byte);

            string encrypted_pwd = Convert.ToBase64String(encrypted_byte);
            return encrypted_pwd;
        }
        #endregion
        #region get customer info
        public customer cusVIP(string CMND)
        {
            IFirebaseClient client = connect();
            FirebaseResponse data = client.Get("Customers/" + CMND);
            customer cusInfo = data.ResultAs<customer>();
            return cusInfo;
        }
        #endregion

        #region get Promotion Info
        public promo promotion(string promoType)
        {
            IFirebaseClient client = connect();
            FirebaseResponse data = client.Get("Promos/" + promoType);
            promo promoInfo = data.ResultAs<promo>();
            return promoInfo;
        }
        #endregion

        #region get Room Prices
        public List<KeyValuePair<string, string>> roomPrices()
        {
            IFirebaseClient client = connect();
            FirebaseResponse data = client.Get("RoomPrices/");
            IDictionary<string, string> mList = JsonConvert.DeserializeObject<IDictionary<string, string>>(data.Body);
            List<KeyValuePair<string, string>> listNumber = mList.ToList();

            return listNumber;
        }
        #endregion
    }
}
