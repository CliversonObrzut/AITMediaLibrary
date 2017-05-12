using System.Collections.Generic;
using Data_Access;

namespace Business_Logic
{
    public class UserLogic
    {
        private readonly UserDAO _userDAO;

        public UserLogic()
        {
            _userDAO = new UserDAO();
        }

        public List<UserModel> GetListOfUsers()
        {
            List<UserModel> users = new List<UserModel>();
            UserDS.TabUserDataTable userTable = _userDAO.GetUserDataTable();

            GetListOfUsersFromDataTable(users, userTable);
            return users;
        }

        public List<UserModel> GetListOfUsersByUserNameAndPassword(string username, string password)
        {
            List<UserModel> users = new List<UserModel>();
            UserDS.TabUserDataTable userTable = _userDAO.GetUserByUserNamePassword(username, password);

            GetListOfUsersFromDataTable(users, userTable);
            return users;
        }

        private static void GetListOfUsersFromDataTable(List<UserModel> users, UserDS.TabUserDataTable userTable)
        {
            foreach (UserDS.TabUserRow row in userTable.Rows)
            {
                UserModel user = UserModel.Parse(row);
                users.Add(user);
            }
        }

        public int AddNewUser(string username, string password, int userLevel, string email)
        {
            return _userDAO.InsertNewUser(username, password, userLevel, email);
        }

        public int UpdatePassword(string newPassword, int userID, int userLevel)
        {
            if (userLevel < 3)
                return -1;
            return _userDAO.UpdatePassword(newPassword, userID);
        }

        public int DeleteUserByUserID(int userID, int userLevel)
        {
            if (userLevel < 3)
                return -1;
            return _userDAO.DeleteUserByUserID(userID);
        }
    }
}
