﻿using System.ComponentModel;
using Data_Access;

namespace Business_Logic
{
    public class UserModel
    {
        
        public int UserID { set; get; }

        [DisplayName("User Name")]
        public string UserName { get; set; }

        [DisplayName("User Level")]
        public int UserLevel { get; set; }

        /// <summary>
        /// Binds the user data from Database to UserModel object.
        /// </summary>
        /// <param name="userRow"></param>
        /// <returns></returns>
        public static UserModel Parse(UserDS.TabUserRow userRow)
        {
            if (userRow == null)
                return null;

            var userModel = new UserModel
            {
                UserID = userRow.UID,
                UserName = userRow.UserName,
                UserLevel = userRow.UserLevel
            };

            return userModel;
        }
    }
}
