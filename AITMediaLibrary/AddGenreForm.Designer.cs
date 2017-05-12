namespace AITMediaLibrary
{
    partial class AddGenreForm
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
            this.genreNameLabel = new System.Windows.Forms.Label();
            this.addGenreTextBox = new System.Windows.Forms.TextBox();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.cancelAddGenreButton = new System.Windows.Forms.Button();
            this.errAddGenreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // genreNameLabel
            // 
            this.genreNameLabel.AutoSize = true;
            this.genreNameLabel.ForeColor = System.Drawing.Color.White;
            this.genreNameLabel.Location = new System.Drawing.Point(23, 32);
            this.genreNameLabel.Name = "genreNameLabel";
            this.genreNameLabel.Size = new System.Drawing.Size(70, 13);
            this.genreNameLabel.TabIndex = 0;
            this.genreNameLabel.Text = "Genre Name:";
            // 
            // addGenreTextBox
            // 
            this.addGenreTextBox.Location = new System.Drawing.Point(26, 49);
            this.addGenreTextBox.Name = "addGenreTextBox";
            this.addGenreTextBox.Size = new System.Drawing.Size(229, 20);
            this.addGenreTextBox.TabIndex = 1;
            this.addGenreTextBox.Click += new System.EventHandler(this.EraseErrorMessage);
            // 
            // addGenreButton
            // 
            this.addGenreButton.Location = new System.Drawing.Point(158, 97);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(97, 23);
            this.addGenreButton.TabIndex = 2;
            this.addGenreButton.Text = "Add";
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // cancelAddGenreButton
            // 
            this.cancelAddGenreButton.Location = new System.Drawing.Point(26, 97);
            this.cancelAddGenreButton.Name = "cancelAddGenreButton";
            this.cancelAddGenreButton.Size = new System.Drawing.Size(105, 23);
            this.cancelAddGenreButton.TabIndex = 3;
            this.cancelAddGenreButton.Text = "Cancel";
            this.cancelAddGenreButton.UseVisualStyleBackColor = true;
            this.cancelAddGenreButton.Click += new System.EventHandler(this.cancelAddGenreButton_Click);
            // 
            // errAddGenreLabel
            // 
            this.errAddGenreLabel.AutoSize = true;
            this.errAddGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errAddGenreLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errAddGenreLabel.Location = new System.Drawing.Point(26, 76);
            this.errAddGenreLabel.Name = "errAddGenreLabel";
            this.errAddGenreLabel.Size = new System.Drawing.Size(0, 13);
            this.errAddGenreLabel.TabIndex = 4;
            // 
            // AddGenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 155);
            this.Controls.Add(this.errAddGenreLabel);
            this.Controls.Add(this.cancelAddGenreButton);
            this.Controls.Add(this.addGenreButton);
            this.Controls.Add(this.addGenreTextBox);
            this.Controls.Add(this.genreNameLabel);
            this.Name = "AddGenreForm";
            this.Text = "Add Genre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genreNameLabel;
        private System.Windows.Forms.TextBox addGenreTextBox;
        private System.Windows.Forms.Button addGenreButton;
        private System.Windows.Forms.Button cancelAddGenreButton;
        private System.Windows.Forms.Label errAddGenreLabel;
    }
}