using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Business_Logic;

namespace AITMediaLibrary
{
    public partial class AdminUserForm : Form
    {
        private readonly UserLogic _userLogic;
        private readonly MediaLogic _mediaLogic;

        private UserModel _selectedUser;

        public AdminUserForm()
        {
            InitializeComponent();
            _userLogic = new UserLogic();
            _mediaLogic = new MediaLogic();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                loggedInUserLabel.Text = @"User:  " + CurrentUser.UserName;
                loggedInLevelLabel.Text = @"Level:  " + CurrentUser.UserLevel;
                RefreshUserList();
                userLevelComboBox.DataSource = Enum.GetValues(typeof(AppEnum.UserLevel));
            }
            catch (Exception)
            {
                userGridView.Text = @"Sorry, error loading the users!";
            }
        }

        private void RefreshUserList()
        {
            List<UserModel> users = _userLogic.GetListOfUsers();
            userGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userGridView.DataSource = users;
            SelectedUserOnLoad(users);
            CleanTextBoxes();
        }

        private void SelectedUserOnLoad(List<UserModel> users)
        {
            UserModel user = users[0];
            _selectedUser = user;
            selectedUserLabel.Text = @"Selected User:  " + user.UserName;
        }

        private void userGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > -1)// -1 is the header row, dont care about it
            {
                //cast datasouece from "object" to list of models. throw exception if not actually
                // a list of user models
                List<UserModel> users = (List<UserModel>)userGridView.DataSource;

                _selectedUser = users.ElementAt(row);//get from this position
                selectedUserLabel.Text = @"Selected User:  " + _selectedUser.UserName;
            }
        }
        private void ArrowKeyUpDown_press(object sender, KeyEventArgs e)
        {
            int rowIndex = userGridView.CurrentCell.RowIndex;
            int colIndex = userGridView.CurrentCell.ColumnIndex;
            if (e.KeyValue == 40 && (userGridView.Rows.Count - 1) != rowIndex)
            {
                rowIndex++;
                DataGridViewCellEventArgs ev = new DataGridViewCellEventArgs(colIndex, rowIndex);
                userGridView_CellClick(sender, ev);
            }
            if (e.KeyValue == 38 && rowIndex != 0)
            {
                rowIndex--;
                DataGridViewCellEventArgs ev = new DataGridViewCellEventArgs(colIndex, rowIndex);
                userGridView_CellClick(sender, ev);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshUserList();
        }

        private void listAllButton_Click(object sender, EventArgs e)
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
                    MessageBox.Show(_selectedUser.UserName + @" password updated!");
                }
                else
                {
                    //didnt
                    MessageBox.Show(@"Something wrong! " + _selectedUser.UserName + @" password not updated!");
                }
                RefreshUserList();
            }
        }

        private bool HasBorrowedOrReserved()
        {
            ReserveModel reserve = _mediaLogic.GetReservedByUser(_selectedUser.UserID);
            List<MediaModel> borroweds = _mediaLogic.GetBorrowedByUser(_selectedUser.UserID);
            if (reserve != null || borroweds.Count > 0)
                return true;
            return false;
        }

        private void deleteSelectedUserButton_Click(object sender, EventArgs e)
        {
            if (_selectedUser != null && _selectedUser.UserName != CurrentUser.UserName)
            {
                if (HasBorrowedOrReserved())
                {
                    MessageBox.Show(@"Not possible to delete because this user has borrowed or reserved media");
                }
                else
                {
                    _userLogic.DeleteUserByUserID(_selectedUser.UserID, CurrentUser.UserLevel);
                    _selectedUser = null;
                    MessageBox.Show(@"Selected user successfully deleted!");
                    RefreshUserList();
                }
            }
            else
                MessageBox.Show(@"Impossible to delete the logged in user!");
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text != "" && passwordTextBox.Text != "" && emailTextBox.Text != "")
            {
                //get enum back out of datasource of combo box......................
                AppEnum.UserLevel userLevel = (AppEnum.UserLevel)Enum.Parse(typeof(AppEnum.UserLevel), userLevelComboBox.Text);

                _userLogic.AddNewUser(userNameTextBox.Text, passwordTextBox.Text, (int)userLevel, emailTextBox.Text);
                //if affectedRows > 0, sucess!
                MessageBox.Show(@"New user successfully created!");
                RefreshUserList();
            }
            else
            {
                MessageBox.Show(@"Missing information!");
            }
        }

        private void changeToAdminMediaButton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(OpenAdminMedia);
            t.Start();
            Close(); // closes the form
        }

        private static void OpenAdminMedia()
        {
            Application.Run(new AdminMediaForm());
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            CurrentUser.UserName = "";
            CurrentUser.UserLevel = 0;

            System.Threading.Thread t = new System.Threading.Thread(OpenLoginForm);
            t.Start();
            Close();
        }

        private static void OpenLoginForm()
        {
            Application.Run(new Login());
        }

        private void CleanTextBoxes(int num = 0)
        {
            if (num != 1)
                searchUserTextBox.Text = "";
            if (num != 2)
                newPasswordTextBox.Text = "";
            if (num != 3)
            {
                userNameTextBox.Text = "";
                passwordTextBox.Text = "";
                emailTextBox.Text = "";
            }
        }

        private void searchUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<UserModel> users = _userLogic.GetListOfUsersByUserName(searchUserTextBox.Text);
                userGridView.DataSource = users;
                SelectedUserOnLoad(users);
                CleanTextBoxes();
            }
            catch (Exception)
            {
                MessageBox.Show(@"User(s) not found!");
                RefreshUserList();
            }
        }
    }
}