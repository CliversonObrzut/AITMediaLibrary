using System;
using System.Windows.Forms;
using Business_Logic;

namespace AITMediaLibrary
{
    public partial class AddDirectorForm : Form
    {
        private readonly MediaLogic _mediaLogic;
        public AddDirectorForm()
        {
            InitializeComponent();
            _mediaLogic = new MediaLogic();
        }

        private void cancelAddDirectorButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addDirectorButton_Click(object sender, EventArgs e)
        {
            if (addDirectorTextBox == null)
            {
                errAddDirectorLabel.Text = @"Nothing typed!";
            }
            else
            {
                _mediaLogic.AddNewDirector(addDirectorTextBox.Text);
                Close();
            }
        }

        private void EraseErrorMessage(object sender, EventArgs e)
        {
            errAddDirectorLabel.Text = "";
        }
    }
}
