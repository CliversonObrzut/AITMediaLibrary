namespace AITMediaLibrary
{
    partial class AddLanguageForm
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
            this.addLanguageLabel = new System.Windows.Forms.Label();
            this.addLanguageTextBox = new System.Windows.Forms.TextBox();
            this.addLanguageButton = new System.Windows.Forms.Button();
            this.cancelAddLanguageButton = new System.Windows.Forms.Button();
            this.errAddLanguageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.addLanguageLabel.AutoSize = true;
            this.addLanguageLabel.ForeColor = System.Drawing.Color.White;
            this.addLanguageLabel.Location = new System.Drawing.Point(23, 32);
            this.addLanguageLabel.Name = "label1";
            this.addLanguageLabel.Size = new System.Drawing.Size(70, 13);
            this.addLanguageLabel.TabIndex = 0;
            this.addLanguageLabel.Text = "Language Name:";
            // 
            // addLanguageTextBox
            // 
            this.addLanguageTextBox.Location = new System.Drawing.Point(26, 49);
            this.addLanguageTextBox.Name = "addLanguageTextBox";
            this.addLanguageTextBox.Size = new System.Drawing.Size(229, 20);
            this.addLanguageTextBox.TabIndex = 1;
            this.addLanguageTextBox.Click += new System.EventHandler(this.EraseErrorMessage);
            // 
            // addLanguageButton
            // 
            this.addLanguageButton.Location = new System.Drawing.Point(158, 97);
            this.addLanguageButton.Name = "addGenreButton";
            this.addLanguageButton.Size = new System.Drawing.Size(97, 23);
            this.addLanguageButton.TabIndex = 2;
            this.addLanguageButton.Text = "Add";
            this.addLanguageButton.UseVisualStyleBackColor = true;
            this.addLanguageButton.Click += new System.EventHandler(this.addLanguageButton_Click);
            // 
            // cancelAddGenreButton
            // 
            this.cancelAddLanguageButton.Location = new System.Drawing.Point(26, 97);
            this.cancelAddLanguageButton.Name = "cancelAddGenreButton";
            this.cancelAddLanguageButton.Size = new System.Drawing.Size(105, 23);
            this.cancelAddLanguageButton.TabIndex = 3;
            this.cancelAddLanguageButton.Text = "Cancel";
            this.cancelAddLanguageButton.UseVisualStyleBackColor = true;
            this.cancelAddLanguageButton.Click += new System.EventHandler(this.cancelAddLanguageButton_Click);
            // 
            // errAddGenreLabel
            // 
            this.errAddLanguageLabel.AutoSize = true;
            this.errAddLanguageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errAddLanguageLabel.ForeColor = System.Drawing.Color.Red;
            this.errAddLanguageLabel.Location = new System.Drawing.Point(26, 76);
            this.errAddLanguageLabel.Name = "errAddGenreLabel";
            this.errAddLanguageLabel.Size = new System.Drawing.Size(0, 13);
            this.errAddLanguageLabel.TabIndex = 4;
            // 
            // AddLanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(284, 155);
            this.Controls.Add(this.errAddLanguageLabel);
            this.Controls.Add(this.cancelAddLanguageButton);
            this.Controls.Add(this.addLanguageButton);
            this.Controls.Add(this.addLanguageTextBox);
            this.Controls.Add(this.addLanguageLabel);
            this.Name = "AddLanguageForm";
            this.Text = "Add Language";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addLanguageLabel;
        private System.Windows.Forms.TextBox addLanguageTextBox;
        private System.Windows.Forms.Button addLanguageButton;
        private System.Windows.Forms.Button cancelAddLanguageButton;
        private System.Windows.Forms.Label errAddLanguageLabel;
    }
}