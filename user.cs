using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement_FireBase
{
    public class User
    {
        #region Declaration
        public string username { get; set; }
        public string pwd { get; set; }
        public string gender { get; set; }
        public string fullname { get; set; }
        public string phoneNum { get; set; }
        public string role { get; set; }
        #endregion

        public static string error = "Username does not exist!";

        #region Show Error
        public static string ShowError()
        {
            return error;
        }
        #endregion

        #region Check if user & pwd are correct
        public static bool IsEqual(User user1, User user2)//input = current user, user in database)
        {
            if (user1 == null || user2 == null) { return false; }

            if (user1.username != user2.username)
            {
                error = "Username does not exist!";
                return false;
            }

            else if (user1.pwd != user2.pwd)
            {
                error = "Username and password does not match!";
                return false;
            }
            return true;
        }
        #endregion

        #region check if user is already existed!
        public static bool compare(User user1, User user2)
        {
            if (user1 == null || user2 == null) { return false; }

            if (user1.username != user2.username)
            {
                error = "Username does not exist!";
                return false;
            }
            return true;
        }
        #endregion
    }
}
