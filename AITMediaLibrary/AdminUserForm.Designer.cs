namespace AITMediaLibrary
{
    partial class AdminUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUserForm));
            this.listOfUsersLabel = new System.Windows.Forms.Label();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.selectedUserLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.updatePasswordButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userLevelLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.userLevelComboBox = new System.Windows.Forms.ComboBox();
            this.toAdminMediaButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.loggedInLevelLabel = new System.Windows.Forms.Label();
            this.loggedInUserLabel = new System.Windows.Forms.Label();
            this.loggedInUserGridView = new System.Windows.Forms.DataGridView();
            this.addUserGridView = new System.Windows.Forms.DataGridView();
            this.deleteUserGridView = new System.Windows.Forms.DataGridView();
            this.addNewUserLabel = new System.Windows.Forms.Label();
            this.changePasswordGridView = new System.Windows.Forms.DataGridView();
            this.deleteUserLabel = new System.Windows.Forms.Label();
            this.changePasswordLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.searchUserTextBox = new System.Windows.Forms.TextBox();
            this.searchUserLabel = new System.Windows.Forms.Label();
            this.selectedUserGridView = new System.Windows.Forms.DataGridView();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchUserButton = new System.Windows.Forms.Button();
            this.listAllButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggedInUserGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addUserGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteUserGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePasswordGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedUserGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfUsersLabel
            // 
            this.listOfUsersLabel.AutoSize = true;
            this.listOfUsersLabel.ForeColor = System.Drawing.Color.White;
            this.listOfUsersLabel.Location = new System.Drawing.Point(55, 75);
            this.listOfUsersLabel.Name = "listOfUsersLabel";
            this.listOfUsersLabel.Size = new System.Drawing.Size(56, 13);
            this.listOfUsersLabel.TabIndex = 0;
            this.listOfUsersLabel.Text = "Users List:";
            // 
            // userGridView
            // 
            this.userGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userGridView.BackgroundColor = System.Drawing.Color.White;
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Location = new System.Drawing.Point(58, 91);
            this.userGridView.Name = "userGridView";
            this.userGridView.Size = new System.Drawing.Size(347, 405);
            this.userGridView.TabIndex = 1;
            this.userGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userGridView_CellClick);
            this.userGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ArrowKeyUpDown_press);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(58, 502);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // selectedUserLabel
            // 
            this.selectedUserLabel.AutoSize = true;
            this.selectedUserLabel.ForeColor = System.Drawing.Color.White;
            this.selectedUserLabel.Location = new System.Drawing.Point(427, 101);
            this.selectedUserLabel.Name = "selectedUserLabel";
            this.selectedUserLabel.Size = new System.Drawing.Size(77, 13);
            this.selectedUserLabel.TabIndex = 3;
            this.selectedUserLabel.Text = "Selected User:";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.newPasswordLabel.Location = new System.Drawing.Point(427, 209);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(81, 13);
            this.newPasswordLabel.TabIndex = 4;
            this.newPasswordLabel.Text = "New Password:";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(514, 206);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(257, 20);
            this.newPasswordTextBox.TabIndex = 5;
            // 
            // updatePasswordButton
            // 
            this.updatePasswordButton.Location = new System.Drawing.Point(430, 235);
            this.updatePasswordButton.Name = "updatePasswordButton";
            this.updatePasswordButton.Size = new System.Drawing.Size(341, 23);
            this.updatePasswordButton.TabIndex = 6;
            this.updatePasswordButton.Text = "Update Password";
            this.updatePasswordButton.UseVisualStyleBackColor = true;
            this.updatePasswordButton.Click += new System.EventHandler(this.updatePasswordButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(430, 290);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(341, 23);
            this.deleteUserButton.TabIndex = 7;
            this.deleteUserButton.Text = "Delete Selected User";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteSelectedUserButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(430, 463);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(341, 23);
            this.addUserButton.TabIndex = 8;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(427, 353);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(63, 13);
            this.userNameLabel.TabIndex = 9;
            this.userNameLabel.Text = "User Name:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(427, 381);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password:";
            // 
            // userLevelLabel
            // 
            this.userLevelLabel.AutoSize = true;
            this.userLevelLabel.ForeColor = System.Drawing.Color.White;
            this.userLevelLabel.Location = new System.Drawing.Point(427, 409);
            this.userLevelLabel.Name = "userLevelLabel";
            this.userLevelLabel.Size = new System.Drawing.Size(61, 13);
            this.userLevelLabel.TabIndex = 11;
            this.userLevelLabel.Text = "User Level:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(427, 438);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(496, 350);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(275, 20);
            this.userNameTextBox.TabIndex = 13;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(496, 378);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(275, 20);
            this.passwordTextBox.TabIndex = 14;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(496, 435);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(275, 20);
            this.emailTextBox.TabIndex = 15;
            // 
            // userLevelComboBox
            // 
            this.userLevelComboBox.FormattingEnabled = true;
            this.userLevelComboBox.Location = new System.Drawing.Point(496, 406);
            this.userLevelComboBox.Name = "userLevelComboBox";
            this.userLevelComboBox.Size = new System.Drawing.Size(275, 21);
            this.userLevelComboBox.TabIndex = 16;
            // 
            // toAdminMediaButton
            // 
            this.toAdminMediaButton.Location = new System.Drawing.Point(536, 12);
            this.toAdminMediaButton.Name = "toAdminMediaButton";
            this.toAdminMediaButton.Size = new System.Drawing.Size(115, 31);
            this.toAdminMediaButton.TabIndex = 17;
            this.toAdminMediaButton.Text = "Go to Media Admin";
            this.toAdminMediaButton.UseVisualStyleBackColor = true;
            this.toAdminMediaButton.Click += new System.EventHandler(this.changeToAdminMediaButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(58, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(218, 46);
            this.logoPictureBox.TabIndex = 28;
            this.logoPictureBox.TabStop = false;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(668, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(115, 31);
            this.logoutButton.TabIndex = 29;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // loggedInLevelLabel
            // 
            this.loggedInLevelLabel.AutoSize = true;
            this.loggedInLevelLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loggedInLevelLabel.Location = new System.Drawing.Point(457, 19);
            this.loggedInLevelLabel.Name = "loggedInLevelLabel";
            this.loggedInLevelLabel.Size = new System.Drawing.Size(36, 13);
            this.loggedInLevelLabel.TabIndex = 33;
            this.loggedInLevelLabel.Text = "Level:";
            // 
            // loggedInUserLabel
            // 
            this.loggedInUserLabel.AutoSize = true;
            this.loggedInUserLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loggedInUserLabel.Location = new System.Drawing.Point(321, 19);
            this.loggedInUserLabel.Name = "loggedInUserLabel";
            this.loggedInUserLabel.Size = new System.Drawing.Size(35, 13);
            this.loggedInUserLabel.TabIndex = 32;
            this.loggedInUserLabel.Text = "User: ";
            // 
            // loggedInUserGridView
            // 
            this.loggedInUserGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loggedInUserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loggedInUserGridView.Location = new System.Drawing.Point(313, 12);
            this.loggedInUserGridView.Name = "loggedInUserGridView";
            this.loggedInUserGridView.Size = new System.Drawing.Size(197, 28);
            this.loggedInUserGridView.TabIndex = 34;
            // 
            // addUserGridView
            // 
            this.addUserGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addUserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addUserGridView.Location = new System.Drawing.Point(417, 338);
            this.addUserGridView.Name = "addUserGridView";
            this.addUserGridView.Size = new System.Drawing.Size(366, 158);
            this.addUserGridView.TabIndex = 35;
            // 
            // deleteUserGridView
            // 
            this.deleteUserGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteUserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteUserGridView.Location = new System.Drawing.Point(417, 284);
            this.deleteUserGridView.Name = "deleteUserGridView";
            this.deleteUserGridView.Size = new System.Drawing.Size(366, 35);
            this.deleteUserGridView.TabIndex = 36;
            // 
            // addNewUserLabel
            // 
            this.addNewUserLabel.AutoSize = true;
            this.addNewUserLabel.ForeColor = System.Drawing.Color.White;
            this.addNewUserLabel.Location = new System.Drawing.Point(414, 322);
            this.addNewUserLabel.Name = "addNewUserLabel";
            this.addNewUserLabel.Size = new System.Drawing.Size(79, 13);
            this.addNewUserLabel.TabIndex = 37;
            this.addNewUserLabel.Text = "Add New User:";
            // 
            // changePasswordGridView
            // 
            this.changePasswordGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.changePasswordGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.changePasswordGridView.Location = new System.Drawing.Point(417, 199);
            this.changePasswordGridView.Name = "changePasswordGridView";
            this.changePasswordGridView.Size = new System.Drawing.Size(366, 65);
            this.changePasswordGridView.TabIndex = 38;
            // 
            // deleteUserLabel
            // 
            this.deleteUserLabel.AutoSize = true;
            this.deleteUserLabel.ForeColor = System.Drawing.Color.White;
            this.deleteUserLabel.Location = new System.Drawing.Point(414, 268);
            this.deleteUserLabel.Name = "deleteUserLabel";
            this.deleteUserLabel.Size = new System.Drawing.Size(66, 13);
            this.deleteUserLabel.TabIndex = 39;
            this.deleteUserLabel.Text = "Delete User:";
            // 
            // changePasswordLabel
            // 
            this.changePasswordLabel.AutoSize = true;
            this.changePasswordLabel.ForeColor = System.Drawing.Color.White;
            this.changePasswordLabel.Location = new System.Drawing.Point(414, 183);
            this.changePasswordLabel.Name = "changePasswordLabel";
            this.changePasswordLabel.Size = new System.Drawing.Size(96, 13);
            this.changePasswordLabel.TabIndex = 40;
            this.changePasswordLabel.Text = "Change Password:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(417, 144);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(366, 33);
            this.dataGridView2.TabIndex = 41;
            // 
            // searchUserTextBox
            // 
            this.searchUserTextBox.Location = new System.Drawing.Point(514, 151);
            this.searchUserTextBox.Name = "searchUserTextBox";
            this.searchUserTextBox.Size = new System.Drawing.Size(176, 20);
            this.searchUserTextBox.TabIndex = 43;
            // 
            // searchUserLabel
            // 
            this.searchUserLabel.AutoSize = true;
            this.searchUserLabel.ForeColor = System.Drawing.Color.White;
            this.searchUserLabel.Location = new System.Drawing.Point(427, 154);
            this.searchUserLabel.Name = "searchUserLabel";
            this.searchUserLabel.Size = new System.Drawing.Size(63, 13);
            this.searchUserLabel.TabIndex = 42;
            this.searchUserLabel.Text = "User Name:";
            // 
            // selectedUserGridView
            // 
            this.selectedUserGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.selectedUserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedUserGridView.Location = new System.Drawing.Point(417, 91);
            this.selectedUserGridView.Name = "selectedUserGridView";
            this.selectedUserGridView.Size = new System.Drawing.Size(366, 33);
            this.selectedUserGridView.TabIndex = 44;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(414, 128);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(44, 13);
            this.searchLabel.TabIndex = 45;
            this.searchLabel.Text = "Search:";
            // 
            // searchUserButton
            // 
            this.searchUserButton.Location = new System.Drawing.Point(696, 149);
            this.searchUserButton.Name = "searchUserButton";
            this.searchUserButton.Size = new System.Drawing.Size(75, 23);
            this.searchUserButton.TabIndex = 46;
            this.searchUserButton.Text = "Search";
            this.searchUserButton.UseVisualStyleBackColor = true;
            this.searchUserButton.Click += new System.EventHandler(this.searchUserButton_Click);
            // 
            // listAllButton
            // 
            this.listAllButton.Location = new System.Drawing.Point(139, 502);
            this.listAllButton.Name = "listAllButton";
            this.listAllButton.Size = new System.Drawing.Size(75, 23);
            this.listAllButton.TabIndex = 47;
            this.listAllButton.Text = "List All";
            this.listAllButton.UseVisualStyleBackColor = true;
            this.listAllButton.Click += new System.EventHandler(this.listAllButton_Click);
            // 
            // AdminUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(835, 537);
            this.Controls.Add(this.listAllButton);
            this.Controls.Add(this.searchUserButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchUserTextBox);
            this.Controls.Add(this.searchUserLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.changePasswordLabel);
            this.Controls.Add(this.deleteUserLabel);
            this.Controls.Add(this.addNewUserLabel);
            this.Controls.Add(this.loggedInLevelLabel);
            this.Controls.Add(this.loggedInUserLabel);
            this.Controls.Add(this.loggedInUserGridView);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.toAdminMediaButton);
            this.Controls.Add(this.userLevelComboBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.userLevelLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.updatePasswordButton);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.selectedUserLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.userGridView);
            this.Controls.Add(this.listOfUsersLabel);
            this.Controls.Add(this.addUserGridView);
            this.Controls.Add(this.deleteUserGridView);
            this.Controls.Add(this.changePasswordGridView);
            this.Controls.Add(this.selectedUserGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminUserForm";
            this.Text = "User Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggedInUserGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addUserGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteUserGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePasswordGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedUserGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listOfUsersLabel;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label selectedUserLabel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Button updatePasswordButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userLevelLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox userLevelComboBox;
        private System.Windows.Forms.Button toAdminMediaButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label loggedInLevelLabel;
        private System.Windows.Forms.Label loggedInUserLabel;
        private System.Windows.Forms.DataGridView loggedInUserGridView;
        private System.Windows.Forms.DataGridView addUserGridView;
        private System.Windows.Forms.DataGridView deleteUserGridView;
        private System.Windows.Forms.Label addNewUserLabel;
        private System.Windows.Forms.DataGridView changePasswordGridView;
        private System.Windows.Forms.Label deleteUserLabel;
        private System.Windows.Forms.Label changePasswordLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox searchUserTextBox;
        private System.Windows.Forms.Label searchUserLabel;
        private System.Windows.Forms.DataGridView selectedUserGridView;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button searchUserButton;
        private System.Windows.Forms.Button listAllButton;
    }
}