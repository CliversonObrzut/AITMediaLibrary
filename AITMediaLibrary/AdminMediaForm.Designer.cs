namespace AITMediaLibrary
{
    partial class AdminMediaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMediaForm));
            this.listOfMediaLabel = new System.Windows.Forms.Label();
            this.mediaGridView = new System.Windows.Forms.DataGridView();
            this.titleLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.publishYearLabel = new System.Windows.Forms.Label();
            this.budgetLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.publishYearTextBox = new System.Windows.Forms.TextBox();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.directorComboBox = new System.Windows.Forms.ComboBox();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.addMediaButton = new System.Windows.Forms.Button();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.addDirectorButton = new System.Windows.Forms.Button();
            this.addLanguageButton = new System.Windows.Forms.Button();
            this.userAdminButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.loggedInLevelLabel = new System.Windows.Forms.Label();
            this.loggedInUserLabel = new System.Windows.Forms.Label();
            this.loggedInUserGridView = new System.Windows.Forms.DataGridView();
            this.addNewMediaGridView = new System.Windows.Forms.DataGridView();
            this.addNewMediaLabel = new System.Windows.Forms.Label();
            this.searchMediaButton = new System.Windows.Forms.Button();
            this.searchMediaTextBox = new System.Windows.Forms.TextBox();
            this.SearchGridView = new System.Windows.Forms.DataGridView();
            this.selectedMediaLabel = new System.Windows.Forms.Label();
            this.selectedMediaGridView = new System.Windows.Forms.DataGridView();
            this.listAllButton = new System.Windows.Forms.Button();
            this.deleteMediaLabel = new System.Windows.Forms.Label();
            this.deleteMediaButton = new System.Windows.Forms.Button();
            this.deleteMediaGridView = new System.Windows.Forms.DataGridView();
            this.updateSelectedMediaLabel = new System.Windows.Forms.Label();
            this.updateSelectedMediaButton = new System.Windows.Forms.Button();
            this.updateMediaGridView = new System.Windows.Forms.DataGridView();
            this.searchLabel = new System.Windows.Forms.Label();
            this.cancelUpdateModeButton = new System.Windows.Forms.Button();
            this.updateMediaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggedInUserGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewMediaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedMediaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteMediaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateMediaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfMediaLabel
            // 
            this.listOfMediaLabel.AutoSize = true;
            this.listOfMediaLabel.ForeColor = System.Drawing.Color.White;
            this.listOfMediaLabel.Location = new System.Drawing.Point(55, 76);
            this.listOfMediaLabel.Name = "listOfMediaLabel";
            this.listOfMediaLabel.Size = new System.Drawing.Size(60, 13);
            this.listOfMediaLabel.TabIndex = 0;
            this.listOfMediaLabel.Text = "Medias List";
            // 
            // mediaGridView
            // 
            this.mediaGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mediaGridView.BackgroundColor = System.Drawing.Color.White;
            this.mediaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mediaGridView.Location = new System.Drawing.Point(58, 92);
            this.mediaGridView.Name = "mediaGridView";
            this.mediaGridView.Size = new System.Drawing.Size(752, 201);
            this.mediaGridView.TabIndex = 1;
            this.mediaGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mediaGridView_CellClick);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.DimGray;
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(472, 322);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.ForeColor = System.Drawing.Color.White;
            this.genreLabel.Location = new System.Drawing.Point(472, 350);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(39, 13);
            this.genreLabel.TabIndex = 3;
            this.genreLabel.Text = "Genre:";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.ForeColor = System.Drawing.Color.White;
            this.directorLabel.Location = new System.Drawing.Point(472, 378);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(47, 13);
            this.directorLabel.TabIndex = 4;
            this.directorLabel.Text = "Director:";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.ForeColor = System.Drawing.Color.White;
            this.languageLabel.Location = new System.Drawing.Point(472, 407);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(58, 13);
            this.languageLabel.TabIndex = 5;
            this.languageLabel.Text = "Language:";
            // 
            // publishYearLabel
            // 
            this.publishYearLabel.AutoSize = true;
            this.publishYearLabel.ForeColor = System.Drawing.Color.White;
            this.publishYearLabel.Location = new System.Drawing.Point(472, 437);
            this.publishYearLabel.Name = "publishYearLabel";
            this.publishYearLabel.Size = new System.Drawing.Size(69, 13);
            this.publishYearLabel.TabIndex = 6;
            this.publishYearLabel.Text = "Publish Year:";
            // 
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.ForeColor = System.Drawing.Color.White;
            this.budgetLabel.Location = new System.Drawing.Point(472, 467);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(44, 13);
            this.budgetLabel.TabIndex = 7;
            this.budgetLabel.Text = "Budget:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(554, 319);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(207, 20);
            this.titleTextBox.TabIndex = 8;
            // 
            // publishYearTextBox
            // 
            this.publishYearTextBox.Location = new System.Drawing.Point(554, 434);
            this.publishYearTextBox.Name = "publishYearTextBox";
            this.publishYearTextBox.Size = new System.Drawing.Size(207, 20);
            this.publishYearTextBox.TabIndex = 9;
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(554, 464);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(207, 20);
            this.budgetTextBox.TabIndex = 10;
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(554, 347);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(207, 21);
            this.genreComboBox.TabIndex = 11;
            // 
            // directorComboBox
            // 
            this.directorComboBox.FormattingEnabled = true;
            this.directorComboBox.Location = new System.Drawing.Point(554, 375);
            this.directorComboBox.Name = "directorComboBox";
            this.directorComboBox.Size = new System.Drawing.Size(207, 21);
            this.directorComboBox.TabIndex = 12;
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Location = new System.Drawing.Point(554, 404);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(207, 21);
            this.languageComboBox.TabIndex = 13;
            // 
            // addMediaButton
            // 
            this.addMediaButton.Location = new System.Drawing.Point(475, 493);
            this.addMediaButton.Name = "addMediaButton";
            this.addMediaButton.Size = new System.Drawing.Size(286, 23);
            this.addMediaButton.TabIndex = 14;
            this.addMediaButton.Text = "Add Media";
            this.addMediaButton.UseVisualStyleBackColor = true;
            this.addMediaButton.Click += new System.EventHandler(this.addMediaButton_Click);
            // 
            // addGenreButton
            // 
            this.addGenreButton.Location = new System.Drawing.Point(771, 345);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(27, 23);
            this.addGenreButton.TabIndex = 15;
            this.addGenreButton.Text = "+";
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // addDirectorButton
            // 
            this.addDirectorButton.Location = new System.Drawing.Point(771, 373);
            this.addDirectorButton.Name = "addDirectorButton";
            this.addDirectorButton.Size = new System.Drawing.Size(27, 23);
            this.addDirectorButton.TabIndex = 16;
            this.addDirectorButton.Text = "+";
            this.addDirectorButton.UseVisualStyleBackColor = true;
            this.addDirectorButton.Click += new System.EventHandler(this.addDirectorButton_Click);
            // 
            // addLanguageButton
            // 
            this.addLanguageButton.Location = new System.Drawing.Point(771, 402);
            this.addLanguageButton.Name = "addLanguageButton";
            this.addLanguageButton.Size = new System.Drawing.Size(27, 23);
            this.addLanguageButton.TabIndex = 17;
            this.addLanguageButton.Text = "+";
            this.addLanguageButton.UseVisualStyleBackColor = true;
            this.addLanguageButton.Click += new System.EventHandler(this.addLanguageButton_Click);
            // 
            // userAdminButton
            // 
            this.userAdminButton.Location = new System.Drawing.Point(564, 12);
            this.userAdminButton.Name = "userAdminButton";
            this.userAdminButton.Size = new System.Drawing.Size(115, 31);
            this.userAdminButton.TabIndex = 18;
            this.userAdminButton.Text = "Go to User Admin";
            this.userAdminButton.UseVisualStyleBackColor = true;
            this.userAdminButton.Click += new System.EventHandler(this.userAdminButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(60, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(218, 46);
            this.logoPictureBox.TabIndex = 29;
            this.logoPictureBox.TabStop = false;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(695, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(115, 31);
            this.logoutButton.TabIndex = 30;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // loggedInLevelLabel
            // 
            this.loggedInLevelLabel.AutoSize = true;
            this.loggedInLevelLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loggedInLevelLabel.Location = new System.Drawing.Point(749, 65);
            this.loggedInLevelLabel.Name = "loggedInLevelLabel";
            this.loggedInLevelLabel.Size = new System.Drawing.Size(36, 13);
            this.loggedInLevelLabel.TabIndex = 36;
            this.loggedInLevelLabel.Text = "Level:";
            // 
            // loggedInUserLabel
            // 
            this.loggedInUserLabel.AutoSize = true;
            this.loggedInUserLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loggedInUserLabel.Location = new System.Drawing.Point(633, 65);
            this.loggedInUserLabel.Name = "loggedInUserLabel";
            this.loggedInUserLabel.Size = new System.Drawing.Size(35, 13);
            this.loggedInUserLabel.TabIndex = 35;
            this.loggedInUserLabel.Text = "User: ";
            // 
            // loggedInUserGridView
            // 
            this.loggedInUserGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.loggedInUserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loggedInUserGridView.Location = new System.Drawing.Point(627, 58);
            this.loggedInUserGridView.Name = "loggedInUserGridView";
            this.loggedInUserGridView.Size = new System.Drawing.Size(183, 28);
            this.loggedInUserGridView.TabIndex = 37;
            // 
            // addNewMediaGridView
            // 
            this.addNewMediaGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addNewMediaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addNewMediaGridView.Location = new System.Drawing.Point(459, 312);
            this.addNewMediaGridView.Name = "addNewMediaGridView";
            this.addNewMediaGridView.Size = new System.Drawing.Size(351, 210);
            this.addNewMediaGridView.TabIndex = 38;
            // 
            // addNewMediaLabel
            // 
            this.addNewMediaLabel.AutoSize = true;
            this.addNewMediaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addNewMediaLabel.Location = new System.Drawing.Point(456, 296);
            this.addNewMediaLabel.Name = "addNewMediaLabel";
            this.addNewMediaLabel.Size = new System.Drawing.Size(86, 13);
            this.addNewMediaLabel.TabIndex = 39;
            this.addNewMediaLabel.Text = "Add New Media:";
            // 
            // searchMediaButton
            // 
            this.searchMediaButton.Location = new System.Drawing.Point(259, 317);
            this.searchMediaButton.Name = "searchMediaButton";
            this.searchMediaButton.Size = new System.Drawing.Size(72, 23);
            this.searchMediaButton.TabIndex = 53;
            this.searchMediaButton.Text = "Search";
            this.searchMediaButton.UseVisualStyleBackColor = true;
            this.searchMediaButton.Click += new System.EventHandler(this.searchMediaButton_Click);
            // 
            // searchMediaTextBox
            // 
            this.searchMediaTextBox.Location = new System.Drawing.Point(69, 319);
            this.searchMediaTextBox.Name = "searchMediaTextBox";
            this.searchMediaTextBox.Size = new System.Drawing.Size(176, 20);
            this.searchMediaTextBox.TabIndex = 50;
            // 
            // SearchGridView
            // 
            this.SearchGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SearchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchGridView.Location = new System.Drawing.Point(58, 312);
            this.SearchGridView.Name = "SearchGridView";
            this.SearchGridView.Size = new System.Drawing.Size(282, 33);
            this.SearchGridView.TabIndex = 48;
            // 
            // selectedMediaLabel
            // 
            this.selectedMediaLabel.AutoSize = true;
            this.selectedMediaLabel.ForeColor = System.Drawing.Color.White;
            this.selectedMediaLabel.Location = new System.Drawing.Point(67, 370);
            this.selectedMediaLabel.Name = "selectedMediaLabel";
            this.selectedMediaLabel.Size = new System.Drawing.Size(84, 13);
            this.selectedMediaLabel.TabIndex = 47;
            this.selectedMediaLabel.Text = "Selected Media:";
            // 
            // selectedMediaGridView
            // 
            this.selectedMediaGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.selectedMediaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedMediaGridView.Location = new System.Drawing.Point(57, 360);
            this.selectedMediaGridView.Name = "selectedMediaGridView";
            this.selectedMediaGridView.Size = new System.Drawing.Size(366, 33);
            this.selectedMediaGridView.TabIndex = 51;
            // 
            // listAllButton
            // 
            this.listAllButton.Location = new System.Drawing.Point(351, 317);
            this.listAllButton.Name = "listAllButton";
            this.listAllButton.Size = new System.Drawing.Size(75, 23);
            this.listAllButton.TabIndex = 55;
            this.listAllButton.Text = "List All";
            this.listAllButton.UseVisualStyleBackColor = true;
            this.listAllButton.Click += new System.EventHandler(this.listAllButton_Click);
            // 
            // deleteMediaLabel
            // 
            this.deleteMediaLabel.AutoSize = true;
            this.deleteMediaLabel.ForeColor = System.Drawing.Color.White;
            this.deleteMediaLabel.Location = new System.Drawing.Point(54, 407);
            this.deleteMediaLabel.Name = "deleteMediaLabel";
            this.deleteMediaLabel.Size = new System.Drawing.Size(73, 13);
            this.deleteMediaLabel.TabIndex = 58;
            this.deleteMediaLabel.Text = "Delete Media:";
            // 
            // deleteMediaButton
            // 
            this.deleteMediaButton.Location = new System.Drawing.Point(70, 429);
            this.deleteMediaButton.Name = "deleteMediaButton";
            this.deleteMediaButton.Size = new System.Drawing.Size(341, 23);
            this.deleteMediaButton.TabIndex = 56;
            this.deleteMediaButton.Text = "Delete Selected Media";
            this.deleteMediaButton.UseVisualStyleBackColor = true;
            this.deleteMediaButton.Click += new System.EventHandler(this.deleteMediaButton_Click);
            // 
            // deleteMediaGridView
            // 
            this.deleteMediaGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteMediaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteMediaGridView.Location = new System.Drawing.Point(57, 423);
            this.deleteMediaGridView.Name = "deleteMediaGridView";
            this.deleteMediaGridView.Size = new System.Drawing.Size(366, 35);
            this.deleteMediaGridView.TabIndex = 57;
            // 
            // updateSelectedMediaLabel
            // 
            this.updateSelectedMediaLabel.AutoSize = true;
            this.updateSelectedMediaLabel.ForeColor = System.Drawing.Color.White;
            this.updateSelectedMediaLabel.Location = new System.Drawing.Point(57, 471);
            this.updateSelectedMediaLabel.Name = "updateSelectedMediaLabel";
            this.updateSelectedMediaLabel.Size = new System.Drawing.Size(119, 13);
            this.updateSelectedMediaLabel.TabIndex = 61;
            this.updateSelectedMediaLabel.Text = "Update Selected Media";
            // 
            // updateSelectedMediaButton
            // 
            this.updateSelectedMediaButton.Location = new System.Drawing.Point(73, 493);
            this.updateSelectedMediaButton.Name = "updateSelectedMediaButton";
            this.updateSelectedMediaButton.Size = new System.Drawing.Size(341, 23);
            this.updateSelectedMediaButton.TabIndex = 59;
            this.updateSelectedMediaButton.Text = "Update Selected Media";
            this.updateSelectedMediaButton.UseVisualStyleBackColor = true;
            this.updateSelectedMediaButton.Click += new System.EventHandler(this.updateSelectedMediaButton_Click);
            // 
            // updateMediaGridView
            // 
            this.updateMediaGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.updateMediaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updateMediaGridView.Location = new System.Drawing.Point(60, 487);
            this.updateMediaGridView.Name = "updateMediaGridView";
            this.updateMediaGridView.Size = new System.Drawing.Size(366, 35);
            this.updateMediaGridView.TabIndex = 60;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchLabel.Location = new System.Drawing.Point(55, 296);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(44, 13);
            this.searchLabel.TabIndex = 62;
            this.searchLabel.Text = "Search:";
            // 
            // cancelUpdateModeButton
            // 
            this.cancelUpdateModeButton.Location = new System.Drawing.Point(73, 493);
            this.cancelUpdateModeButton.Name = "cancelUpdateModeButton";
            this.cancelUpdateModeButton.Size = new System.Drawing.Size(341, 23);
            this.cancelUpdateModeButton.TabIndex = 63;
            this.cancelUpdateModeButton.Text = "Cancel Update";
            this.cancelUpdateModeButton.UseVisualStyleBackColor = true;
            this.cancelUpdateModeButton.Click += new System.EventHandler(this.cancelUpdateModeButton_Click);
            // 
            // updateMediaButton
            // 
            this.updateMediaButton.Location = new System.Drawing.Point(475, 493);
            this.updateMediaButton.Name = "updateMediaButton";
            this.updateMediaButton.Size = new System.Drawing.Size(286, 23);
            this.updateMediaButton.TabIndex = 64;
            this.updateMediaButton.Text = "Update Media";
            this.updateMediaButton.UseVisualStyleBackColor = true;
            this.updateMediaButton.Click += new System.EventHandler(this.updateMediaButton_Click);
            // 
            // AdminMediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(873, 534);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.updateSelectedMediaLabel);
            this.Controls.Add(this.deleteMediaLabel);
            this.Controls.Add(this.deleteMediaButton);
            this.Controls.Add(this.deleteMediaGridView);
            this.Controls.Add(this.listAllButton);
            this.Controls.Add(this.searchMediaButton);
            this.Controls.Add(this.searchMediaTextBox);
            this.Controls.Add(this.SearchGridView);
            this.Controls.Add(this.selectedMediaLabel);
            this.Controls.Add(this.selectedMediaGridView);
            this.Controls.Add(this.addNewMediaLabel);
            this.Controls.Add(this.loggedInLevelLabel);
            this.Controls.Add(this.loggedInUserLabel);
            this.Controls.Add(this.loggedInUserGridView);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.userAdminButton);
            this.Controls.Add(this.addLanguageButton);
            this.Controls.Add(this.addDirectorButton);
            this.Controls.Add(this.addGenreButton);
            this.Controls.Add(this.addMediaButton);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.directorComboBox);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.budgetTextBox);
            this.Controls.Add(this.publishYearTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.budgetLabel);
            this.Controls.Add(this.publishYearLabel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.mediaGridView);
            this.Controls.Add(this.listOfMediaLabel);
            this.Controls.Add(this.updateMediaButton);
            this.Controls.Add(this.addNewMediaGridView);
            this.Controls.Add(this.updateSelectedMediaButton);
            this.Controls.Add(this.cancelUpdateModeButton);
            this.Controls.Add(this.updateMediaGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMediaForm";
            this.Text = "Media Admin";
            this.Load += new System.EventHandler(this.AdminMedia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loggedInUserGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewMediaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedMediaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteMediaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateMediaGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listOfMediaLabel;
        private System.Windows.Forms.DataGridView mediaGridView;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label publishYearLabel;
        private System.Windows.Forms.Label budgetLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox publishYearTextBox;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.ComboBox directorComboBox;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Button addMediaButton;
        private System.Windows.Forms.Button addGenreButton;
        private System.Windows.Forms.Button addDirectorButton;
        private System.Windows.Forms.Button addLanguageButton;
        private System.Windows.Forms.Button userAdminButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label loggedInLevelLabel;
        private System.Windows.Forms.Label loggedInUserLabel;
        private System.Windows.Forms.DataGridView loggedInUserGridView;
        private System.Windows.Forms.DataGridView addNewMediaGridView;
        private System.Windows.Forms.Label addNewMediaLabel;
        private System.Windows.Forms.Button searchMediaButton;
        private System.Windows.Forms.TextBox searchMediaTextBox;
        private System.Windows.Forms.DataGridView SearchGridView;
        private System.Windows.Forms.Label selectedMediaLabel;
        private System.Windows.Forms.DataGridView selectedMediaGridView;
        private System.Windows.Forms.Button listAllButton;
        private System.Windows.Forms.Label deleteMediaLabel;
        private System.Windows.Forms.Button deleteMediaButton;
        private System.Windows.Forms.DataGridView deleteMediaGridView;
        private System.Windows.Forms.Label updateSelectedMediaLabel;
        private System.Windows.Forms.Button updateSelectedMediaButton;
        private System.Windows.Forms.DataGridView updateMediaGridView;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button cancelUpdateModeButton;
        private System.Windows.Forms.Button updateMediaButton;
    }
}