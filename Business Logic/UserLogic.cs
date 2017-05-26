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

        /// <summary>
        /// Returns the list of users as user model.
        /// </summary>
        /// <returns></returns>
        public List<UserModel> GetListOfUsers()
        {
            List<UserModel> users = new List<UserModel>();
            UserDS.TabUserDataTable userTable = _userDAO.GetUserDataTable();

            GetListOfUsersFromDataTable(users, userTable);
            return users;
        }

        /// <summary>
        /// Returns a list of users by user name and password as user model.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public List<UserModel> GetListOfUsersByUserNameAndPassword(string username, string password)
        {
            List<UserModel> users = new List<UserModel>();
            UserDS.TabUserDataTable userTable = _userDAO.GetUserByUserNamePassword(username, password);

            GetListOfUsersFromDataTable(users, userTable);
            return users;
        }

        /// <summary>
        /// Returns a list of users by user name as user model
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public List<UserModel> GetListOfUsersByUserName(string username)
        {
            List<UserModel> users = new List<UserModel>();
            UserDS.TabUserDataTable userTable = _userDAO.GetUserByUserName(username);

            GetListOfUsersFromDataTable(users, userTable);
            return users;
        }

        /// <summary>
        /// Binds the list of users from Database to a list of user model.
        /// </summary>
        /// <param name="users"></param>
        /// <param name="userTable"></param>
        private static void GetListOfUsersFromDataTable(List<UserModel> users, UserDS.TabUserDataTable userTable)
        {
            foreach (UserDS.TabUserRow row in userTable.Rows)
            {
                UserModel user = UserModel.Parse(row);
                users.Add(user);
            }
        }

        /// <summary>
        /// Adds a new user to Database.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="userLevel"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public int AddNewUser(string username, string password, int userLevel, string email)
        {
            return _userDAO.InsertNewUser(username, password, userLevel, email);
        }

        /// <summary>
        /// Updates the password of a selected user if the current logged in user has level 3 of access.
        /// </summary>
        /// <param name="newPassword"></param>
        /// <param name="userID"></param>
        /// <param name="userLevel"></param>
        /// <returns></returns>
        public int UpdatePassword(string newPassword, int userID, int userLevel)
        {
            if (userLevel < 3)
                return -1;
            return _userDAO.UpdatePassword(newPassword, userID);
        }

        /// <summary>
        /// Delete a user from Datatable if the current logged in user has rights to do it.
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="userLevel"></param>
        /// <returns></returns>
        public int DeleteUserByUserID(int userID, int userLevel)
        {
            if (userLevel < 3)
                return -1;
            return _userDAO.DeleteUserByUserID(userID);
        }
    }
}
