using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Logic;

namespace AITMediaLibrary
{
    public partial class AdminForm : Form
    {
        private readonly UserLogic _userLogic = new UserLogic();

        private UserModel _selectedUser = null;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            RefreshUserList();
            userLevelComboBox.DataSource = Enum.GetValues(typeof(AppEnum.UserLevel));
        }

        private void RefreshUserList()
        {
            userGridView.DataSource = _userLogic.GetListOfUsers();
        }

        private void userGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > -1)// -1 is the header row, dont care about it
            {
                //cast datasouece from "object" to list of models. throw exception if not actually
                // a list of user models
                List<UserModel> users = (List<UserModel>)userGridView.DataSource;

                _selectedUser = users.ElementAt<UserModel>(row);//get from this position
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshUserList();
        }

        private void updatePasswordButton_Click(object sender, EventArgs e)
        {
            //TODO for assignment: make sure password matches basic criteria
            if (_selectedUser != null)
            {
                int rowsAffected = _userLogic.UpdatePassword(newPasswordTextBox.Text, _selectedUser.UserID, CurrentUser.UserLevel);
                if (rowsAffected > 0)
                {
                    //worked
                    MessageBox.Show(_selectedUser.UserName + " password updated!");
                }
                else
                {
                    //didnt
                }
                RefreshUserList();
            }
        }

        private void deleteSelectedUserButton_Click(object sender, EventArgs e)
        {
            if (_selectedUser != null)
            {
                int affectedRows = _userLogic.DeleteUserByUserID(_selectedUser.UserID, CurrentUser.UserLevel);

                _selectedUser = null;

                RefreshUserList();

            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            //get enum back out of datasource of combo box......................
            AppEnum.UserLevel userLevel = (AppEnum.UserLevel)Enum.Parse(typeof(AppEnum.UserLevel), userLevelComboBox.Text);

            int affectedRows = _userLogic.AddNewUser(userNameTextBox.Text, passwordTextBox.Text, (int)userLevel, emailTextBox.Text);
            //if affectedRows > 0, sucess!

            Refresh();
        }

        private void changeToAdminMediaButton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(OpenAdminMedia);
            t.Start();
            Close(); // closes the form
        }

        private static void OpenAdminMedia()
        {
            Application.Run(new AdminMedia());
        }
    }
}