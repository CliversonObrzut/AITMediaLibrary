namespace AITMediaLibrary
{
    partial class AddDirectorForm
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
            this.directorNameLabel = new System.Windows.Forms.Label();
            this.addDirectorTextBox = new System.Windows.Forms.TextBox();
            this.addDirectorButton = new System.Windows.Forms.Button();
            this.cancelAddDirectorButton = new System.Windows.Forms.Button();
            this.errAddDirectorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // directorNameLabel
            // 
            this.directorNameLabel.AutoSize = true;
            this.directorNameLabel.ForeColor = System.Drawing.Color.White;
            this.directorNameLabel.Location = new System.Drawing.Point(23, 32);
            this.directorNameLabel.Name = "directorNameLabel";
            this.directorNameLabel.Size = new System.Drawing.Size(70, 13);
            this.directorNameLabel.TabIndex = 0;
            this.directorNameLabel.Text = "Director Name:";
            // 
            // addDirectorTextBox
            // 
            this.addDirectorTextBox.Location = new System.Drawing.Point(26, 49);
            this.addDirectorTextBox.Name = "addDirectorTextBox";
            this.addDirectorTextBox.Size = new System.Drawing.Size(229, 20);
            this.addDirectorTextBox.TabIndex = 1;
            this.addDirectorTextBox.Click += new System.EventHandler(this.EraseErrorMessage);
            // 
            // addDirectorButton
            // 
            this.addDirectorButton.Location = new System.Drawing.Point(158, 97);
            this.addDirectorButton.Name = "addDirectorButton";
            this.addDirectorButton.Size = new System.Drawing.Size(97, 23);
            this.addDirectorButton.TabIndex = 2;
            this.addDirectorButton.Text = "Add";
            this.addDirectorButton.UseVisualStyleBackColor = true;
            this.addDirectorButton.Click += new System.EventHandler(this.addDirectorButton_Click);
            // 
            // cancelAddDirectorButton
            // 
            this.cancelAddDirectorButton.Location = new System.Drawing.Point(26, 97);
            this.cancelAddDirectorButton.Name = "cancelAddDirectorButton";
            this.cancelAddDirectorButton.Size = new System.Drawing.Size(105, 23);
            this.cancelAddDirectorButton.TabIndex = 3;
            this.cancelAddDirectorButton.Text = "Cancel";
            this.cancelAddDirectorButton.UseVisualStyleBackColor = true;
            this.cancelAddDirectorButton.Click += new System.EventHandler(this.cancelAddDirectorButton_Click);
            // 
            // errAddDirectorLabel
            // 
            this.errAddDirectorLabel.AutoSize = true;
            this.errAddDirectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errAddDirectorLabel.ForeColor = System.Drawing.Color.Red;
            this.errAddDirectorLabel.Location = new System.Drawing.Point(26, 76);
            this.errAddDirectorLabel.Name = "errAddDirectorLabel";
            this.errAddDirectorLabel.Size = new System.Drawing.Size(0, 13);
            this.errAddDirectorLabel.TabIndex = 4;
            // 
            // AddDirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 155);
            this.Controls.Add(this.errAddDirectorLabel);
            this.Controls.Add(this.cancelAddDirectorButton);
            this.Controls.Add(this.addDirectorButton);
            this.Controls.Add(this.addDirectorTextBox);
            this.Controls.Add(this.directorNameLabel);
            this.Name = "AddDirectorForm";
            this.Text = "Add Director";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label directorNameLabel;
        private System.Windows.Forms.TextBox addDirectorTextBox;
        private System.Windows.Forms.Button addDirectorButton;
        private System.Windows.Forms.Button cancelAddDirectorButton;
        private System.Windows.Forms.Label errAddDirectorLabel;
    }
}