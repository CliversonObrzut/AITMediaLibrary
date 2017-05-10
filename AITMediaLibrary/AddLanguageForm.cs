using System;
using System.Windows.Forms;
using Business_Logic;

namespace AITMediaLibrary
{
    public partial class AddLanguageForm : Form
    {
        private readonly MediaLogic _mediaLogic;
        public AddLanguageForm()
        {
            InitializeComponent();
            _mediaLogic = new MediaLogic();
        }

        private void cancelAddLanguageButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addLanguageButton_Click(object sender, EventArgs e)
        {
            if (addLanguageTextBox == null)
            {
                errAddLanguageLabel.Text = @"Nothing typed!";
            }
            else
            {
                _mediaLogic.AddNewLanguage(addLanguageTextBox.Text);
                Close();
            }
        }

        private void EraseErrorMessage(object sender, EventArgs e)
        {
            errAddLanguageLabel.Text = "";
        }
    }
}
