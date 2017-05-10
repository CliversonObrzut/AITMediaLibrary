using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business_Logic;

namespace AITMediaLibrary
{
    public partial class Login : Form
    {
        private readonly UserLogic _userLogic;
        public Login()
        {
            InitializeComponent();
            _userLogic = new UserLogic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<UserModel> users = _userLogic.GetListOfUsersByUserNameAndPassword(usernameTextBox.Text, passwordTextBox.Text);

            if (users.Count > 0)
            {
                CurrentUser.UserName = users[0].UserName;
                CurrentUser.UserLevel = users[0].UserLevel;

                if (users[0].UserLevel == 3) //go to admin page/form
                {
                    System.Threading.Thread t = new System.Threading.Thread(OpenAdminForm);
                    t.Start();
                }
                else //go to student/normal form
                {
                    System.Threading.Thread t = new System.Threading.Thread(OpenMediaBrowser);
                    t.Start();
                }

                Close(); // closes the form
            }
            else
            {
                errorLabel.Text = @"Error: no user matching this username and password";
            }
        }

        private static void OpenAdminForm()
        {
            Application.Run(new AdminForm());
        }

        public static void OpenMediaBrowser()
        {
            Application.Run(new MediaBrowser());
        }
    }
}
