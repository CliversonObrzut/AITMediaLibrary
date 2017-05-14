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

        public int InsertNewUser(string userName, string password, int userLevel, string email)
        {
            return _tabUserTableAdapter.InsertNewUser(userName, password, userLevel, email);
        }

        public int UpdatePassword(string password, int userID)
        {
            return _tabUserTableAdapter.UpdatePassword(password, userID);
        }

        public int DeleteUserByUserID(int userID)
        {
            return _tabUserTableAdapter.DeleteUserByUserID(userID);
        }


    }
}
