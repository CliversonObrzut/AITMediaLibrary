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
            ((System.ComponentModel.ISupportInitialize)(this.mediaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userLabel.Location = new System.Drawing.Point(51, 22);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(35, 13);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "User: ";
            // 
            // mediaGridView
            // 
            this.mediaGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mediaGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.mediaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mediaGridView.Location = new System.Drawing.Point(54, 54);
            this.mediaGridView.Name = "mediaGridView";
            this.mediaGridView.Size = new System.Drawing.Size(775, 222);
            this.mediaGridView.TabIndex = 1;
            this.mediaGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mediaGridView_CellClick);
            // 
            // publishYearLabel
            // 
            this.publishYearLabel.AutoSize = true;
            this.publishYearLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.publishYearLabel.Location = new System.Drawing.Point(506, 306);
            this.publishYearLabel.Name = "publishYearLabel";
            this.publishYearLabel.Size = new System.Drawing.Size(69, 13);
            this.publishYearLabel.TabIndex = 2;
            this.publishYearLabel.Text = "Publish Year:";
            // 
            // publishYearTextBox
            // 
            this.publishYearTextBox.Location = new System.Drawing.Point(585, 303);
            this.publishYearTextBox.Name = "publishYearTextBox";
            this.publishYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.publishYearTextBox.TabIndex = 3;
            // 
            // yearSearchButton
            // 
            this.yearSearchButton.Location = new System.Drawing.Point(701, 301);
            this.yearSearchButton.Name = "yearSearchButton";
            this.yearSearchButton.Size = new System.Drawing.Size(126, 23);
            this.yearSearchButton.TabIndex = 4;
            this.yearSearchButton.Text = "Search";
            this.yearSearchButton.UseVisualStyleBackColor = true;
            this.yearSearchButton.Click += new System.EventHandler(this.yearSearchButton_Click);
            // 
            // listAllButton
            // 
            this.listAllButton.Location = new System.Drawing.Point(54, 301);
            this.listAllButton.Name = "listAllButton";
            this.listAllButton.Size = new System.Drawing.Size(120, 23);
            this.listAllButton.TabIndex = 5;
            this.listAllButton.Text = "List All Media";
            this.listAllButton.UseVisualStyleBackColor = true;
            this.listAllButton.Click += new System.EventHandler(this.listAllButton_Click);
            // 
            // selectedMediaLabel
            // 
            this.selectedMediaLabel.AutoSize = true;
            this.selectedMediaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectedMediaLabel.Location = new System.Drawing.Point(54, 340);
            this.selectedMediaLabel.Name = "selectedMediaLabel";
            this.selectedMediaLabel.Size = new System.Drawing.Size(84, 13);
            this.selectedMediaLabel.TabIndex = 6;
            this.selectedMediaLabel.Text = "Selected Media:";
            // 
            // directorNameLabel
            // 
            this.directorNameLabel.AutoSize = true;
            this.directorNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.directorNameLabel.Location = new System.Drawing.Point(506, 340);
            this.directorNameLabel.Name = "directorNameLabel";
            this.directorNameLabel.Size = new System.Drawing.Size(78, 13);
            this.directorNameLabel.TabIndex = 7;
            this.directorNameLabel.Text = "Director Name:";
            // 
            // directorNameTextBox
            // 
            this.directorNameTextBox.Location = new System.Drawing.Point(585, 337);
            this.directorNameTextBox.Name = "directorNameTextBox";
            this.directorNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.directorNameTextBox.TabIndex = 8;
            // 
            // directorSearchButton
            // 
            this.directorSearchButton.Location = new System.Drawing.Point(701, 335);
            this.directorSearchButton.Name = "directorSearchButton";
            this.directorSearchButton.Size = new System.Drawing.Size(126, 23);
            this.directorSearchButton.TabIndex = 9;
            this.directorSearchButton.Text = "Search";
            this.directorSearchButton.UseVisualStyleBackColor = true;
            this.directorSearchButton.Click += new System.EventHandler(this.directorSearchButton_Click);
            // 
            // errorDBLoadingLabel
            // 
            this.errorDBLoadingLabel.AutoSize = true;
            this.errorDBLoadingLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.errorDBLoadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorDBLoadingLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorDBLoadingLabel.Location = new System.Drawing.Point(57, 379);
            this.errorDBLoadingLabel.Name = "errorDBLoadingLabel";
            this.errorDBLoadingLabel.Size = new System.Drawing.Size(0, 15);
            this.errorDBLoadingLabel.TabIndex = 10;
            // 
            // titleSearchButton
            // 
            this.titleSearchButton.Location = new System.Drawing.Point(701, 370);
            this.titleSearchButton.Name = "titleSearchButton";
            this.titleSearchButton.Size = new System.Drawing.Size(126, 23);
            this.titleSearchButton.TabIndex = 13;
            this.titleSearchButton.Text = "Search";
            this.titleSearchButton.UseVisualStyleBackColor = true;
            this.titleSearchButton.Click += new System.EventHandler(this.titleSearchButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(585, 372);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 12;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLabel.Location = new System.Drawing.Point(506, 375);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Title:";
            // 
            // languageSearchButton
            // 
            this.languageSearchButton.Location = new System.Drawing.Point(701, 406);
            this.languageSearchButton.Name = "languageSearchButton";
            this.languageSearchButton.Size = new System.Drawing.Size(126, 23);
            this.languageSearchButton.TabIndex = 16;
            this.languageSearchButton.Text = "Search";
            this.languageSearchButton.UseVisualStyleBackColor = true;
            this.languageSearchButton.Click += new System.EventHandler(this.languageSearchButton_Click);
            // 
            // languageTextBox
            // 
            this.languageTextBox.Location = new System.Drawing.Point(585, 408);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.Size = new System.Drawing.Size(100, 20);
            this.languageTextBox.TabIndex = 15;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.languageLabel.Location = new System.Drawing.Point(506, 411);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(58, 13);
            this.languageLabel.TabIndex = 14;
            this.languageLabel.Text = "Language:";
            // 
            // genreSearchButton
            // 
            this.genreSearchButton.Location = new System.Drawing.Point(701, 442);
            this.genreSearchButton.Name = "genreSearchButton";
            this.genreSearchButton.Size = new System.Drawing.Size(126, 23);
            this.genreSearchButton.TabIndex = 19;
            this.genreSearchButton.Text = "Search";
            this.genreSearchButton.UseVisualStyleBackColor = true;
            this.genreSearchButton.Click += new System.EventHandler(this.genreSearchButton_Click);
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(585, 444);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(100, 20);
            this.genreTextBox.TabIndex = 18;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.genreLabel.Location = new System.Drawing.Point(506, 447);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(39, 13);
            this.genreLabel.TabIndex = 17;
            this.genreLabel.Text = "Genre:";
            // 
            // budgetSearchButton
            // 
            this.budgetSearchButton.Location = new System.Drawing.Point(701, 476);
            this.budgetSearchButton.Name = "budgetSearchButton";
            this.budgetSearchButton.Size = new System.Drawing.Size(126, 23);
            this.budgetSearchButton.TabIndex = 22;
            this.budgetSearchButton.Text = "Search";
            this.budgetSearchButton.UseVisualStyleBackColor = true;
            this.budgetSearchButton.Click += new System.EventHandler(this.budgetSearchButton_Click);
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(585, 478);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(100, 20);
            this.budgetTextBox.TabIndex = 21;
            // 
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.budgetLabel.Location = new System.Drawing.Point(506, 481);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(44, 13);
            this.budgetLabel.TabIndex = 20;
            this.budgetLabel.Text = "Budget:";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.levelLabel.Location = new System.Drawing.Point(339, 22);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(36, 13);
            this.levelLabel.TabIndex = 23;
            this.levelLabel.Text = "Level:";
            // 
            // MediaBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(891, 522);
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
            this.Controls.Add(this.mediaGridView);
            this.Controls.Add(this.userLabel);
            this.Name = "MediaBrowser";
            this.Text = "Media Browser";
            this.Load += new System.EventHandler(this.MediaBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaGridView)).EndInit();
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
    }
}