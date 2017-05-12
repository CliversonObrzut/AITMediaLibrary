using System;
using System.Windows.Forms;
using Business_Logic;

namespace AITMediaLibrary
{
    public partial class AddGenreForm : Form
    {
        private readonly MediaLogic _mediaLogic;
        public AddGenreForm()
        {
            InitializeComponent();
            _mediaLogic = new MediaLogic();
        }

        private void cancelAddGenreButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            if (addGenreTextBox == null)
            {
                errAddGenreLabel.Text = @"Nothing typed!";
            }
            else
            {
                _mediaLogic.AddNewGenre(addGenreTextBox.Text);
                Close();
            }
        }

        private void EraseErrorMessage(object sender, EventArgs e)
        {
            errAddGenreLabel.Text = "";
        }
    }
}
