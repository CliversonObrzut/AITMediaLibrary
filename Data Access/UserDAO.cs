using System;
using Data_Access.UserDSTableAdapters;

namespace Data_Access
{
    public class UserDAO
    {
        private readonly UserDS _userDataSet;
        private readonly TabUserTableAdapter _tabUserTableAdapter;

        public UserDAO()
        {
            _userDataSet = new UserDS();
            _tabUserTableAdapter = new TabUserTableAdapter();
        }

        /// <summary>
        /// Returns all users from Database
        /// </summary>
        /// <returns></returns>
        public UserDS.TabUserDataTable GetUserDataTable()
        {
            try
            {
                _tabUserTableAdapter.FillAll(_userDataSet.TabUser);
                return _userDataSet.TabUser; 
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Returns user data by its name and password (Login)
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public UserDS.TabUserDataTable GetUserByUserNamePassword(string username, string password)
        {
            try
            {
                _tabUserTableAdapter.FillByUserNamePassword(_userDataSet.TabUser, username, password);
                return _userDataSet.TabUser;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Returns user data by its name
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public UserDS.TabUserDataTable GetUserByUserName(string username)
        {
            try
            {
                _tabUserTableAdapter.FillByUserName(_userDataSet.TabUser, username);
                return _userDataSet.TabUser;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Insert new user into Database
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="userLevel"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public int InsertNewUser(string userName, string password, int userLevel, string email)
        {
            return _tabUserTableAdapter.InsertNewUser(userName, password, userLevel, email);
        }

        /// <summary>
        /// Updates user´s password in Database
        /// </summary>
        /// <param name="password"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public int UpdatePassword(string password, int userID)
        {
            return _tabUserTableAdapter.UpdatePassword(password, userID);
        }

        /// <summary>
        /// Delete user from Database
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public int DeleteUserByUserID(int userID)
        {
            return _tabUserTableAdapter.DeleteUserByUserID(userID);
        }


    }
}
