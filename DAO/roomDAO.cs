using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HotelManagement_FireBase.DAO
{
    public class roomDAO
    {

        #region connect to db
        DataProvider provider = new DataProvider();
        IFirebaseClient client = DataProvider.Instance.connect();
        #endregion
        public static int width = 50;
        public static int height = 50;
        private static roomDAO instance;

        internal static roomDAO Instance
        {
            get { if (instance == null) instance = new roomDAO(); return roomDAO.instance; }
            private set { roomDAO.instance = value; }
        }
        public roomDAO() { }

        public int RoomCounter()
        {
            
            List<Room> roomList = new List<Room>();
            var data = client.Get("/Rooms");
            var dList = JsonConvert.DeserializeObject<IDictionary<string, Room>>(data.Body);
            var lRoom = dList.Select(r => new
            {
                id = r.Value.ID,
                type = r.Value.type,
                stt = r.Value.status,
                price = r.Value.price
            }).ToList();
            int roomCount = 0;
            foreach (var item in lRoom)
            {
                roomCount += 1;
            }
            return roomCount;
        }
    }
}
