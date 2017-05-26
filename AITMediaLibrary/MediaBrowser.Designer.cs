namespace AITMediaLibrary
{
    partial class MediaBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaBrowser));
            this.userLabel = new System.Windows.Forms.Label();
            this.mediaGridView = new System.Windows.Forms.DataGridView();
            this.publishYearLabel = new System.Windows.Forms.Label();
            this.publishYearTextBox = new System.Windows.Forms.TextBox();
            this.yearSearchButton = new System.Windows.Forms.Button();
            this.listAllButton = new System.Windows.Forms.Button();
            this.selectedMediaLabel = new System.Windows.Forms.Label();
            this.directorNameLabel = new System.Windows.Forms.Label();
            this.directorNameTextBox = new System.Windows.Forms.TextBox();
            this.directorSearchButton = new System.Windows.Forms.Button();
            this.errorDBLoadingLabel = new System.Windows.Forms.Label();
            this.titleSearchButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.languageSearchButton = new System.Windows.Forms.Button();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.genreSearchButton = new System.Windows.Forms.Button();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.budgetSearchButton = new System.Windows.Forms.Button();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.budgetLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.filtersLabel = new System.Windows.Forms.Label();
            this.listMediaLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.filtersGridView = new System.Windows.Forms.DataGridView();
            this.selectedMediaGridView = new System.Windows.Forms.DataGridView();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.reserveButton = new System.Windows.Forms.Button();
            this.borrowButton = new System.Windows.Forms.Button();
            this.returnMediaButton = new System.Windows.Forms.Button();
            this.borrowedMediaComboBox = new System.Windows.Forms.ComboBox();
            this.unreserveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedMediaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userLabel.Location = new System.Drawing.Point(642, 68);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(35, 13);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "User: ";
            // 
            // mediaGridView
            // 
            this.mediaGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mediaGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.mediaGridView.BackgroundColor = System.Drawing.Color.White;
            this.mediaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mediaGridView.Location = new System.Drawing.Point(52, 95);
            this.mediaGridView.Name = "mediaGridView";
            this.mediaGridView.Size = new System.Drawing.Size(775, 222);
            this.mediaGridView.TabIndex = 1;
            this.mediaGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mediaGridView_CellClick);
            this.mediaGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ArrowKeyUpDown_press);
            // 
            // publishYearLabel
            // 
            this.publishYearLabel.AutoSize = true;
            this.publishYearLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.publishYearLabel.Location = new System.Drawing.Point(89, 407);
            this.publishYearLabel.Name = "publishYearLabel";
            this.publishYearLabel.Size = new System.Drawing.Size(69, 13);
            this.publishYearLabel.TabIndex = 2;
            this.publishYearLabel.Text = "Publish Year:";
            // 
            // publishYearTextBox
            // 
            this.publishYearTextBox.Location = new System.Drawing.Point(168, 404);
            this.publishYearTextBox.Name = "publishYearTextBox";
            this.publishYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.publishYearTextBox.TabIndex = 3;
            this.publishYearTextBox.Click += new System.EventHandler(this.publishYearTextBox_Click);
            // 
            // yearSearchButton
            // 
            this.yearSearchButton.Location = new System.Drawing.Point(284, 402);
            this.yearSearchButton.Name = "yearSearchButton";
            this.yearSearchButton.Size = new System.Drawing.Size(126, 23);
            this.yearSearchButton.TabIndex = 4;
            this.yearSearchButton.Text = "Search";
            this.yearSearchButton.UseVisualStyleBackColor = true;
            this.yearSearchButton.Click += new System.EventHandler(this.yearSearchButton_Click);
            // 
            // listAllButton
            // 
            this.listAllButton.Location = new System.Drawing.Point(437, 323);
            this.listAllButton.Name = "listAllButton";
            this.listAllButton.Size = new System.Drawing.Size(126, 23);
            this.listAllButton.TabIndex = 5;
            this.listAllButton.Text = "List All Media";
            this.listAllButton.UseVisualStyleBackColor = true;
            this.listAllButton.Click += new System.EventHandler(this.listAllButton_Click);
            // 
            // selectedMediaLabel
            // 
            this.selectedMediaLabel.AutoSize = true;
            this.selectedMediaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectedMediaLabel.Location = new System.Drawing.Point(58, 328);
            this.selectedMediaLabel.Name = "selectedMediaLabel";
            this.selectedMediaLabel.Size = new System.Drawing.Size(84, 13);
            this.selectedMediaLabel.TabIndex = 6;
            this.selectedMediaLabel.Text = "Selected Media:";
            // 
            // directorNameLabel
            // 
            this.directorNameLabel.AutoSize = true;
            this.directorNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.directorNameLabel.Location = new System.Drawing.Point(89, 441);
            this.directorNameLabel.Name = "directorNameLabel";
            this.directorNameLabel.Size = new System.Drawing.Size(78, 13);
            this.directorNameLabel.TabIndex = 7;
            this.directorNameLabel.Text = "Director Name:";
            // 
            // directorNameTextBox
            // 
            this.directorNameTextBox.Location = new System.Drawing.Point(168, 438);
            this.directorNameTextBox.Name = "directorNameTextBox";
            this.directorNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.directorNameTextBox.TabIndex = 8;
            this.directorNameTextBox.Click += new System.EventHandler(this.directorNameTextBox_Click);
            // 
            // directorSearchButton
            // 
            this.directorSearchButton.Location = new System.Drawing.Point(284, 436);
            this.directorSearchButton.Name = "directorSearchButton";
            this.directorSearchButton.Size = new System.Drawing.Size(126, 23);
            this.directorSearchButton.TabIndex = 9;
            this.directorSearchButton.Text = "Search";
            this.directorSearchButton.UseVisualStyleBackColor = true;
            this.directorSearchButton.Click += new System.EventHandler(this.directorSearchButton_Click);
            // 
            // errorDBLoadingLabel
            // 
            this.errorDBLoadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.errorDBLoadingLabel.AutoSize = true;
            this.errorDBLoadingLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.errorDBLoadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorDBLoadingLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorDBLoadingLabel.Location = new System.Drawing.Point(256, 354);
            this.errorDBLoadingLabel.Name = "errorDBLoadingLabel";
            this.errorDBLoadingLabel.Size = new System.Drawing.Size(0, 15);
            this.errorDBLoadingLabel.TabIndex = 10;
            this.errorDBLoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleSearchButton
            // 
            this.titleSearchButton.Location = new System.Drawing.Point(284, 471);
            this.titleSearchButton.Name = "titleSearchButton";
            this.titleSearchButton.Size = new System.Drawing.Size(126, 23);
            this.titleSearchButton.TabIndex = 13;
            this.titleSearchButton.Text = "Search";
            this.titleSearchButton.UseVisualStyleBackColor = true;
            this.titleSearchButton.Click += new System.EventHandler(this.titleSearchButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(168, 473);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 12;
            this.titleTextBox.Click += new System.EventHandler(this.titleTextBox_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLabel.Location = new System.Drawing.Point(89, 476);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Title:";
            // 
            // languageSearchButton
            // 
            this.languageSearchButton.Location = new System.Drawing.Point(659, 401);
            this.languageSearchButton.Name = "languageSearchButton";
            this.languageSearchButton.Size = new System.Drawing.Size(126, 23);
            this.languageSearchButton.TabIndex = 16;
            this.languageSearchButton.Text = "Search";
            this.languageSearchButton.UseVisualStyleBackColor = true;
            this.languageSearchButton.Click += new System.EventHandler(this.languageSearchButton_Click);
            // 
            // languageTextBox
            // 
            this.languageTextBox.Location = new System.Drawing.Point(543, 403);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.Size = new System.Drawing.Size(100, 20);
            this.languageTextBox.TabIndex = 15;
            this.languageTextBox.Click += new System.EventHandler(this.languageTextBox_Click);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.languageLabel.Location = new System.Drawing.Point(464, 406);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(58, 13);
            this.languageLabel.TabIndex = 14;
            this.languageLabel.Text = "Language:";
            // 
            // genreSearchButton
            // 
            this.genreSearchButton.Location = new System.Drawing.Point(659, 437);
            this.genreSearchButton.Name = "genreSearchButton";
            this.genreSearchButton.Size = new System.Drawing.Size(126, 23);
            this.genreSearchButton.TabIndex = 19;
            this.genreSearchButton.Text = "Search";
            this.genreSearchButton.UseVisualStyleBackColor = true;
            this.genreSearchButton.Click += new System.EventHandler(this.genreSearchButton_Click);
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(543, 439);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(100, 20);
            this.genreTextBox.TabIndex = 18;
            this.genreTextBox.Click += new System.EventHandler(this.genreTextBox_Click);
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.genreLabel.Location = new System.Drawing.Point(464, 442);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(39, 13);
            this.genreLabel.TabIndex = 17;
            this.genreLabel.Text = "Genre:";
            // 
            // budgetSearchButton
            // 
            this.budgetSearchButton.Location = new System.Drawing.Point(659, 471);
            this.budgetSearchButton.Name = "budgetSearchButton";
            this.budgetSearchButton.Size = new System.Drawing.Size(126, 23);
            this.budgetSearchButton.TabIndex = 22;
            this.budgetSearchButton.Text = "Search";
            this.budgetSearchButton.UseVisualStyleBackColor = true;
            this.budgetSearchButton.Click += new System.EventHandler(this.budgetSearchButton_Click);
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(543, 473);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(100, 20);
            this.budgetTextBox.TabIndex = 21;
            this.budgetTextBox.Click += new System.EventHandler(this.budgetTextBox_Click);
            // 
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.budgetLabel.Location = new System.Drawing.Point(464, 476);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(44, 13);
            this.budgetLabel.TabIndex = 20;
            this.budgetLabel.Text = "Budget:";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.levelLabel.Location = new System.Drawing.Point(766, 68);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(36, 13);
            this.levelLabel.TabIndex = 23;
            this.levelLabel.Text = "Level:";
            // 
            // filtersLabel
            // 
            this.filtersLabel.AutoSize = true;
            this.filtersLabel.ForeColor = System.Drawing.Color.White;
            this.filtersLabel.Location = new System.Drawing.Point(49, 363);
            this.filtersLabel.Name = "filtersLabel";
            this.filtersLabel.Size = new System.Drawing.Size(37, 13);
            this.filtersLabel.TabIndex = 25;
            this.filtersLabel.Text = "Filters:";
            // 
            // listMediaLabel
            // 
            this.listMediaLabel.AutoSize = true;
            this.listMediaLabel.ForeColor = System.Drawing.Color.White;
            this.listMediaLabel.Location = new System.Drawing.Point(49, 79);
            this.listMediaLabel.Name = "listMediaLabel";
            this.listMediaLabel.Size = new System.Drawing.Size(63, 13);
            this.listMediaLabel.TabIndex = 26;
            this.listMediaLabel.Text = "Medias List:";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(52, 13);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(218, 46);
            this.logoPictureBox.TabIndex = 27;
            this.logoPictureBox.TabStop = false;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(711, 13);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(115, 31);
            this.logoutButton.TabIndex = 28;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // filtersGridView
            // 
            this.filtersGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.filtersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filtersGridView.Location = new System.Drawing.Point(52, 380);
            this.filtersGridView.Name = "filtersGridView";
            this.filtersGridView.Size = new System.Drawing.Size(775, 130);
            this.filtersGridView.TabIndex = 29;
            // 
            // selectedMediaGridView
            // 
            this.selectedMediaGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.selectedMediaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedMediaGridView.Location = new System.Drawing.Point(52, 323);
            this.selectedMediaGridView.Name = "selectedMediaGridView";
            this.selectedMediaGridView.Size = new System.Drawing.Size(358, 23);
            this.selectedMediaGridView.TabIndex = 30;
            // 
            // userGridView
            // 
            this.userGridView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Location = new System.Drawing.Point(634, 61);
            this.userGridView.Name = "userGridView";
            this.userGridView.Size = new System.Drawing.Size(193, 28);
            this.userGridView.TabIndex = 31;
            // 
            // reserveButton
            // 
            this.reserveButton.Location = new System.Drawing.Point(569, 323);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(126, 23);
            this.reserveButton.TabIndex = 32;
            this.reserveButton.Text = "Reserve Media";
            this.reserveButton.UseVisualStyleBackColor = true;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // borrowButton
            // 
            this.borrowButton.Location = new System.Drawing.Point(700, 323);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(126, 23);
            this.borrowButton.TabIndex = 33;
            this.borrowButton.Text = "Borrow Media";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // returnMediaButton
            // 
            this.returnMediaButton.Location = new System.Drawing.Point(701, 351);
            this.returnMediaButton.Name = "returnMediaButton";
            this.returnMediaButton.Size = new System.Drawing.Size(126, 23);
            this.returnMediaButton.TabIndex = 34;
            this.returnMediaButton.Text = "Return Media";
            this.returnMediaButton.UseVisualStyleBackColor = true;
            this.returnMediaButton.Click += new System.EventHandler(this.returnMedia_Click);
            // 
            // borrowedMediaComboBox
            // 
            this.borrowedMediaComboBox.FormattingEnabled = true;
            this.borrowedMediaComboBox.Location = new System.Drawing.Point(437, 352);
            this.borrowedMediaComboBox.Name = "borrowedMediaComboBox";
            this.borrowedMediaComboBox.Size = new System.Drawing.Size(258, 21);
            this.borrowedMediaComboBox.TabIndex = 35;
            // 
            // unreserveButton
            // 
            this.unreserveButton.Location = new System.Drawing.Point(569, 323);
            this.unreserveButton.Name = "unreserveButton";
            this.unreserveButton.Size = new System.Drawing.Size(126, 23);
            this.unreserveButton.TabIndex = 36;
            this.unreserveButton.Text = "UnReserve Media";
            this.unreserveButton.UseVisualStyleBackColor = true;
            this.unreserveButton.Click += new System.EventHandler(this.unreserveButton_Click);
            // 
            // MediaBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(891, 522);
            this.Controls.Add(this.borrowedMediaComboBox);
            this.Controls.Add(this.returnMediaButton);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.reserveButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.listMediaLabel);
            this.Controls.Add(this.filtersLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.budgetSearchButton);
            this.Controls.Add(this.budgetTextBox);
            this.Controls.Add(this.budgetLabel);
            this.Controls.Add(this.genreSearchButton);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.languageSearchButton);
            this.Controls.Add(this.languageTextBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.titleSearchButton);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.errorDBLoadingLabel);
            this.Controls.Add(this.directorSearchButton);
            this.Controls.Add(this.directorNameTextBox);
            this.Controls.Add(this.directorNameLabel);
            this.Controls.Add(this.selectedMediaLabel);
            this.Controls.Add(this.listAllButton);
            this.Controls.Add(this.yearSearchButton);
            this.Controls.Add(this.publishYearTextBox);
            this.Controls.Add(this.publishYearLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.mediaGridView);
            this.Controls.Add(this.filtersGridView);
            this.Controls.Add(this.selectedMediaGridView);
            this.Controls.Add(this.userGridView);
            this.Controls.Add(this.unreserveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MediaBrowser";
            this.Text = "Media Browser";
            this.Load += new System.EventHandler(this.MediaBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedMediaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.DataGridView mediaGridView;
        private System.Windows.Forms.Label publishYearLabel;
        private System.Windows.Forms.TextBox publishYearTextBox;
        private System.Windows.Forms.Button yearSearchButton;
        private System.Windows.Forms.Button listAllButton;
        private System.Windows.Forms.Label selectedMediaLabel;
        private System.Windows.Forms.Label directorNameLabel;
        private System.Windows.Forms.TextBox directorNameTextBox;
        private System.Windows.Forms.Button directorSearchButton;
        private System.Windows.Forms.Label errorDBLoadingLabel;
        private System.Windows.Forms.Button titleSearchButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button languageSearchButton;
        private System.Windows.Forms.TextBox languageTextBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Button genreSearchButton;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Button budgetSearchButton;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.Label budgetLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label filtersLabel;
        private System.Windows.Forms.Label listMediaLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.DataGridView filtersGridView;
        private System.Windows.Forms.DataGridView selectedMediaGridView;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.Button returnMediaButton;
        private System.Windows.Forms.ComboBox borrowedMediaComboBox;
        private System.Windows.Forms.Button unreserveButton;
    }
}