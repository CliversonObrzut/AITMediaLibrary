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
            this.changeToAdminMediaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfUsersLabel
            // 
            this.listOfUsersLabel.AutoSize = true;
            this.listOfUsersLabel.ForeColor = System.Drawing.Color.White;
            this.listOfUsersLabel.Location = new System.Drawing.Point(15, 22);
            this.listOfUsersLabel.Name = "listOfUsersLabel";
            this.listOfUsersLabel.Size = new System.Drawing.Size(65, 13);
            this.listOfUsersLabel.TabIndex = 0;
            this.listOfUsersLabel.Text = "List of Users";
            // 
            // userGridView
            // 
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Location = new System.Drawing.Point(16, 42);
            this.userGridView.Name = "userGridView";
            this.userGridView.Size = new System.Drawing.Size(347, 405);
            this.userGridView.TabIndex = 1;
            this.userGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userGridView_CellContentClick);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(16, 476);
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
            this.selectedUserLabel.Location = new System.Drawing.Point(394, 42);
            this.selectedUserLabel.Name = "selectedUserLabel";
            this.selectedUserLabel.Size = new System.Drawing.Size(77, 13);
            this.selectedUserLabel.TabIndex = 3;
            this.selectedUserLabel.Text = "Selected User:";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.newPasswordLabel.Location = new System.Drawing.Point(394, 79);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(81, 13);
            this.newPasswordLabel.TabIndex = 4;
            this.newPasswordLabel.Text = "New Password:";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(481, 76);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(317, 20);
            this.newPasswordTextBox.TabIndex = 5;
            // 
            // updatePasswordButton
            // 
            this.updatePasswordButton.Location = new System.Drawing.Point(397, 124);
            this.updatePasswordButton.Name = "updatePasswordButton";
            this.updatePasswordButton.Size = new System.Drawing.Size(401, 23);
            this.updatePasswordButton.TabIndex = 6;
            this.updatePasswordButton.Text = "Update Password";
            this.updatePasswordButton.UseVisualStyleBackColor = true;
            this.updatePasswordButton.Click += new System.EventHandler(this.updatePasswordButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(397, 192);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(401, 23);
            this.deleteUserButton.TabIndex = 7;
            this.deleteUserButton.Text = "Delete Selected User";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteSelectedUserButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(397, 424);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(401, 23);
            this.addUserButton.TabIndex = 8;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(394, 270);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(63, 13);
            this.userNameLabel.TabIndex = 9;
            this.userNameLabel.Text = "User Name:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(394, 306);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password:";
            // 
            // userLevelLabel
            // 
            this.userLevelLabel.AutoSize = true;
            this.userLevelLabel.ForeColor = System.Drawing.Color.White;
            this.userLevelLabel.Location = new System.Drawing.Point(394, 342);
            this.userLevelLabel.Name = "userLevelLabel";
            this.userLevelLabel.Size = new System.Drawing.Size(61, 13);
            this.userLevelLabel.TabIndex = 11;
            this.userLevelLabel.Text = "User Level:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(394, 379);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(463, 267);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(335, 20);
            this.userNameTextBox.TabIndex = 13;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(463, 303);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(335, 20);
            this.passwordTextBox.TabIndex = 14;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(463, 376);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(335, 20);
            this.emailTextBox.TabIndex = 15;
            // 
            // userLevelComboBox
            // 
            this.userLevelComboBox.FormattingEnabled = true;
            this.userLevelComboBox.Location = new System.Drawing.Point(463, 339);
            this.userLevelComboBox.Name = "userLevelComboBox";
            this.userLevelComboBox.Size = new System.Drawing.Size(335, 21);
            this.userLevelComboBox.TabIndex = 16;
            // 
            // changeToAdminMediaButton
            // 
            this.changeToAdminMediaButton.Location = new System.Drawing.Point(699, 476);
            this.changeToAdminMediaButton.Name = "changeToAdminMediaButton";
            this.changeToAdminMediaButton.Size = new System.Drawing.Size(99, 23);
            this.changeToAdminMediaButton.TabIndex = 17;
            this.changeToAdminMediaButton.Text = "Admin Medias";
            this.changeToAdminMediaButton.UseVisualStyleBackColor = true;
            this.changeToAdminMediaButton.Click += new System.EventHandler(this.changeToAdminMediaButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(835, 537);
            this.Controls.Add(this.changeToAdminMediaButton);
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
            this.Name = "AdminForm";
            this.Text = "User Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
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
        private System.Windows.Forms.Button changeToAdminMediaButton;
    }
}