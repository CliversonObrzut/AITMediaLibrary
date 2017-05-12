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
            ((System.ComponentModel.ISupportInitialize)(this.mediaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfMediaLabel
            // 
            this.listOfMediaLabel.AutoSize = true;
            this.listOfMediaLabel.ForeColor = System.Drawing.Color.White;
            this.listOfMediaLabel.Location = new System.Drawing.Point(13, 13);
            this.listOfMediaLabel.Name = "listOfMediaLabel";
            this.listOfMediaLabel.Size = new System.Drawing.Size(72, 13);
            this.listOfMediaLabel.TabIndex = 0;
            this.listOfMediaLabel.Text = "List of Medias";
            // 
            // mediaGridView
            // 
            this.mediaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mediaGridView.Location = new System.Drawing.Point(16, 39);
            this.mediaGridView.Name = "mediaGridView";
            this.mediaGridView.Size = new System.Drawing.Size(845, 232);
            this.mediaGridView.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(16, 298);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.ForeColor = System.Drawing.Color.White;
            this.genreLabel.Location = new System.Drawing.Point(16, 326);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(39, 13);
            this.genreLabel.TabIndex = 3;
            this.genreLabel.Text = "Genre:";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.ForeColor = System.Drawing.Color.White;
            this.directorLabel.Location = new System.Drawing.Point(16, 354);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(47, 13);
            this.directorLabel.TabIndex = 4;
            this.directorLabel.Text = "Director:";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.ForeColor = System.Drawing.Color.White;
            this.languageLabel.Location = new System.Drawing.Point(16, 383);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(58, 13);
            this.languageLabel.TabIndex = 5;
            this.languageLabel.Text = "Language:";
            // 
            // publishYearLabel
            // 
            this.publishYearLabel.AutoSize = true;
            this.publishYearLabel.ForeColor = System.Drawing.Color.White;
            this.publishYearLabel.Location = new System.Drawing.Point(16, 413);
            this.publishYearLabel.Name = "publishYearLabel";
            this.publishYearLabel.Size = new System.Drawing.Size(69, 13);
            this.publishYearLabel.TabIndex = 6;
            this.publishYearLabel.Text = "Publish Year:";
            // 
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.ForeColor = System.Drawing.Color.White;
            this.budgetLabel.Location = new System.Drawing.Point(13, 443);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(44, 13);
            this.budgetLabel.TabIndex = 7;
            this.budgetLabel.Text = "Budget:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(98, 295);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(265, 20);
            this.titleTextBox.TabIndex = 8;
            // 
            // publishYearTextBox
            // 
            this.publishYearTextBox.Location = new System.Drawing.Point(98, 410);
            this.publishYearTextBox.Name = "publishYearTextBox";
            this.publishYearTextBox.Size = new System.Drawing.Size(265, 20);
            this.publishYearTextBox.TabIndex = 9;
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(98, 440);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(265, 20);
            this.budgetTextBox.TabIndex = 10;
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(98, 323);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(265, 21);
            this.genreComboBox.TabIndex = 11;
            // 
            // directorComboBox
            // 
            this.directorComboBox.FormattingEnabled = true;
            this.directorComboBox.Location = new System.Drawing.Point(98, 351);
            this.directorComboBox.Name = "directorComboBox";
            this.directorComboBox.Size = new System.Drawing.Size(265, 21);
            this.directorComboBox.TabIndex = 12;
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Location = new System.Drawing.Point(98, 380);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(265, 21);
            this.languageComboBox.TabIndex = 13;
            // 
            // addMediaButton
            // 
            this.addMediaButton.Location = new System.Drawing.Point(19, 479);
            this.addMediaButton.Name = "addMediaButton";
            this.addMediaButton.Size = new System.Drawing.Size(344, 23);
            this.addMediaButton.TabIndex = 14;
            this.addMediaButton.Text = "Add Media";
            this.addMediaButton.UseVisualStyleBackColor = true;
            this.addMediaButton.Click += new System.EventHandler(this.addMediaButton_Click);
            // 
            // addGenreButton
            // 
            this.addGenreButton.Location = new System.Drawing.Point(370, 321);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(26, 23);
            this.addGenreButton.TabIndex = 15;
            this.addGenreButton.Text = "+";
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // addDirectorButton
            // 
            this.addDirectorButton.Location = new System.Drawing.Point(370, 349);
            this.addDirectorButton.Name = "addDirectorButton";
            this.addDirectorButton.Size = new System.Drawing.Size(26, 23);
            this.addDirectorButton.TabIndex = 16;
            this.addDirectorButton.Text = "+";
            this.addDirectorButton.UseVisualStyleBackColor = true;
            this.addDirectorButton.Click += new System.EventHandler(this.addDirectorButton_Click);
            // 
            // addLanguageButton
            // 
            this.addLanguageButton.Location = new System.Drawing.Point(370, 378);
            this.addLanguageButton.Name = "addLanguageButton";
            this.addLanguageButton.Size = new System.Drawing.Size(26, 23);
            this.addLanguageButton.TabIndex = 17;
            this.addLanguageButton.Text = "+";
            this.addLanguageButton.UseVisualStyleBackColor = true;
            this.addLanguageButton.Click += new System.EventHandler(this.addLanguageButton_Click);
            // 
            // userAdminButton
            // 
            this.userAdminButton.Location = new System.Drawing.Point(748, 8);
            this.userAdminButton.Name = "userAdminButton";
            this.userAdminButton.Size = new System.Drawing.Size(113, 23);
            this.userAdminButton.TabIndex = 18;
            this.userAdminButton.Text = "Go to User Admin";
            this.userAdminButton.UseVisualStyleBackColor = true;
            this.userAdminButton.Click += new System.EventHandler(this.userAdminButton_Click);
            // 
            // AdminMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(873, 519);
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
            this.Name = "AdminMediaForm";
            this.Text = "Media Admin";
            this.Load += new System.EventHandler(this.AdminMedia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaGridView)).EndInit();
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
    }
}