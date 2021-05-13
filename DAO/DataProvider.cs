﻿using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        #region
        public string GetIDBill(string rID)
        {
            IFirebaseClient client = this.connect();
            FirebaseResponse res = client.Get("/Bills" + rID);
            IDictionary<string, Bill> Bill_List = JsonConvert.DeserializeObject<IDictionary<string, Bill>>(res.Body);
            string billID = Bill_List.Select(b => new { bID = b.Value.BillID }).ToString();
            return billID;
        }
        #endregion
        #region get date check in
        public string getdCheckIn(string roomID) //input = RoomID //output = dCheckIn
        {
            IFirebaseClient client = connect();
            FirebaseResponse data = client.Get(@"Rooms/" + roomID);
            Room RoomInfo = data.ResultAs<Room>();
            string dateCheckIn = RoomInfo.dateCheckIn.ToString();
            return dateCheckIn;
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
    }
}
