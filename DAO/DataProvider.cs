using FireSharp.Interfaces;
using FireSharp.Config;
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
    }
}
