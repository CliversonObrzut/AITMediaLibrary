using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business_Logic;

namespace AITMediaLibrary
{
    public partial class MediaBrowser : Form
    {
        private readonly MediaLogic _mediaLogic;

        private MediaModel _selectedMedia;

        public MediaBrowser()
        {
            _mediaLogic = new MediaLogic();
            InitializeComponent();
        }

        private void MediaBrowser_Load(object sender, EventArgs e)
        {
            try
            {
                userLabel.Text = @"User:  " + CurrentUser.UserName;
                levelLabel.Text = @"Level:  " + CurrentUser.UserLevel;
                RefresMediaList();
                FillBorrowedComboBox();

            }
            catch (Exception)
            {
                MessageBox.Show(@"Sorry, It was not possible to load the data", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefresMediaList()
        {
            List<MediaModel> medias = _mediaLogic.ListMedia();
            mediaGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mediaGridView.DataSource = medias;
            SelectedMediaOnLoad(medias);
            CheckReservesAndBorrows();
            CleanTextBoxes();
        }

        private void yearSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<MediaModel> medias = _mediaLogic.ListMediaByPublishYear(int.Parse(publishYearTextBox.Text));
                mediaGridView.DataSource = medias;
                SelectedMediaOnLoad(medias);
                CleanTextBoxes(1);
            }
            catch (Exception)
            {
                SearchErrorMessage();
                MediaBrowser_Load(sender,e);
            }
        }

        private void directorSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<MediaModel> medias = _mediaLogic.ListMediaByDirectorName(directorNameTextBox.Text);
                mediaGridView.DataSource = medias;
                SelectedMediaOnLoad(medias);
                CleanTextBoxes(2);
            }
            catch (Exception)
            {
                SearchErrorMessage();
                MediaBrowser_Load(sender,e);
            }
        }

        private void titleSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<MediaModel> medias = _mediaLogic.ListMediaByTitle(titleTextBox.Text);
                mediaGridView.DataSource = medias;
                SelectedMediaOnLoad(medias);
                CleanTextBoxes(3);
            }
            catch (Exception)
            {
                SearchErrorMessage();
                MediaBrowser_Load(sender, e);
            }
        }

        private void languageSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<MediaModel> medias = _mediaLogic.ListMediaByLanguage(languageTextBox.Text);
                mediaGridView.DataSource = medias;
                SelectedMediaOnLoad(medias);
                CleanTextBoxes(4);
            }
            catch (Exception)
            {
                SearchErrorMessage();
                MediaBrowser_Load(sender, e);
            }
        }

        private void genreSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<MediaModel> medias = _mediaLogic.ListMediaByGenre(genreTextBox.Text);
                mediaGridView.DataSource = medias;
                SelectedMediaOnLoad(medias);
                CleanTextBoxes(5);
            }
            catch (Exception)
            {
                SearchErrorMessage();
                MediaBrowser_Load(sender, e);
            }
        }

        private void budgetSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<MediaModel> medias = _mediaLogic.ListMediaByBudget(decimal.Parse(budgetTextBox.Text));
                mediaGridView.DataSource = medias;
                SelectedMediaOnLoad(medias);
                CleanTextBoxes(6);
            }
            catch (Exception)
            {
                SearchErrorMessage();
                MediaBrowser_Load(sender, e);
            }
        }

        private void listAllButton_Click(object sender, EventArgs e)
        {
            RefresMediaList();
        }

        private void mediaGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                List<MediaModel> medias = (List<MediaModel>)mediaGridView.DataSource;
                MediaModel media = medias[row];
                _selectedMedia = media;
                CheckReservesAndBorrows();
                selectedMediaLabel.Text = @"Selected Media: " + _selectedMedia.MediaName;
            }
        }

        private void CheckReservesAndBorrows()
        {
            ReserveModel reserve = _mediaLogic.GetReserveByMediaID(_selectedMedia.MediaId);
            BorrowModel borrow = _mediaLogic.GetBorrowedByMedia(_selectedMedia.MediaId);

            if (reserve != null && reserve.UID == CurrentUser.UserID)
            {
                reserveButton.Visible = false;
            }
            else
            {
                reserveButton.Visible = true;
                if (borrow != null && borrow.UID == CurrentUser.UserID)
                {
                    reserveButton.Enabled = false;
                    unreserveButton.Enabled = false;
                }
                else
                {
                    reserveButton.Enabled = true;
                    unreserveButton.Enabled = true;
                }
                    
            }

            if (borrow != null)
                borrowButton.Enabled = false;
            else
                borrowButton.Enabled = true;
        }

        private void SelectedMediaOnLoad(List<MediaModel> medias)
        {
            MediaModel media = medias[0];
            _selectedMedia = media;
            selectedMediaLabel.Text = @"Selected Media: " + media.MediaName;
        }

        private void SearchErrorMessage()
        {
            MessageBox.Show(@"Sorry, the search doesn't match any value from database");
        }

        private void CleanTextBoxes(int num=0)
        {
            if(num != 1)
                publishYearTextBox.Text = "";
            if(num != 2)
                directorNameTextBox.Text = "";
            if(num != 3)
                titleTextBox.Text = "";
            if(num != 4)
                languageTextBox.Text = "";
            if(num != 5)
                genreTextBox.Text = "";
            if(num != 6)
                budgetTextBox.Text = "";
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            CurrentUser.UserName = "";
            CurrentUser.UserLevel = 0;
            CurrentUser.UserID = 0;

            System.Threading.Thread t = new System.Threading.Thread(OpenLoginForm);
            t.Start();
            Close();
        }

        private static void OpenLoginForm()
        {
            Application.Run(new Login());
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            if (mediaGridView.CurrentRow != null)
            {
                ReserveModel reserve = _mediaLogic.GetReserveByMediaID(_selectedMedia.MediaId);
                if (reserve != null)
                    MessageBox.Show(@"This media is reserved by another user!");
                else
                {
                    _mediaLogic.AddReserve(_selectedMedia.MediaId, CurrentUser.UserID);
                    MessageBox.Show(@"Media reserved!");
                    CheckReservesAndBorrows();
                    mediaGridView.Focus();
                } 
            }
            else
                MessageBox.Show(@"None media is selected!");
        }

        private void unreserveButton_Click(object sender, EventArgs e)
        {
            if (mediaGridView.CurrentRow != null)
            {
                ReserveModel reserve = _mediaLogic.GetReserveByMediaID(_selectedMedia.MediaId);

                _mediaLogic.DeleteReserve(reserve.RID);
                MessageBox.Show(@"Media reserve canceled!");
                CheckReservesAndBorrows();
                mediaGridView.Focus();
            }
            else
                MessageBox.Show(@"None media is selected!");
        }

        private void ArrowKeyUpDown_press(object sender, KeyEventArgs e)
        {
            int rowIndex = mediaGridView.CurrentCell.RowIndex;
            int colIndex = mediaGridView.CurrentCell.ColumnIndex;
            if (e.KeyValue == 40 && (mediaGridView.Rows.Count-1) != rowIndex)
            {
                rowIndex++;
                DataGridViewCellEventArgs ev = new DataGridViewCellEventArgs(colIndex, rowIndex);
                mediaGridView_CellClick(sender, ev);
            }
            if (e.KeyValue == 38 && rowIndex != 0)
            {
                rowIndex--;
                DataGridViewCellEventArgs ev = new DataGridViewCellEventArgs(colIndex, rowIndex);
                mediaGridView_CellClick(sender, ev);
            }
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            if (mediaGridView.CurrentRow != null)
            {
                ReserveModel reserve = _mediaLogic.GetReserveByMediaID(_selectedMedia.MediaId);
                if (reserve != null && reserve.UID != CurrentUser.UserID)
                {
                    MessageBox.Show(@"You can not borrow because this media is reserved by another user!", @"Failed", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                }
                else
                {
                    _mediaLogic.AddBorrow(_selectedMedia.MediaId, CurrentUser.UserID);
                    MessageBox.Show(@"Media borrowed successfully!");
                    CheckReservesAndBorrows();
                    FillBorrowedComboBox();
                    if (reserveButton.Visible == false)
                        unreserveButton_Click(sender, e);
                    mediaGridView.Focus();
                }
            }
            else
                MessageBox.Show(@"None media is selected!");
        }

        public void FillBorrowedComboBox()
        {
            List<MediaModel> medias = _mediaLogic.GetBorrowedByUser(CurrentUser.UserID);
            if (medias.Count > 0)
            {
                returnMediaButton.Enabled = true;
                borrowedMediaComboBox.DataSource = medias;
                borrowedMediaComboBox.ValueMember = "MediaID";
                borrowedMediaComboBox.DisplayMember = "MediaName";
            }
            else
            {
                borrowedMediaComboBox.DataSource = medias;
                borrowedMediaComboBox.Text = "";
                returnMediaButton.Enabled = false;
            }
        }

        private void returnMedia_Click(object sender, EventArgs e)
        {
            BorrowModel borrow = _mediaLogic.GetBorrowedByMedia(int.Parse(borrowedMediaComboBox.SelectedValue.ToString()));
            _mediaLogic.ReturnBorrow(borrow.BID);
            borrow.ActualReturnDate = DateTime.Now;
            string lateFeeMessage = "";
            if (borrow.IsLate())
                lateFeeMessage = "Late fee to pay: $ " + borrow.LateFee;
            MessageBox.Show(@"Media returned successfully! " + lateFeeMessage);
            CheckReservesAndBorrows();
            FillBorrowedComboBox();
            mediaGridView.Focus();
        }

        private void publishYearTextBox_Click(object sender, EventArgs e)
        {
            CleanTextBoxes(1);
        }

        private void directorNameTextBox_Click(object sender, EventArgs e)
        {
            CleanTextBoxes(2);
        }

        private void titleTextBox_Click(object sender, EventArgs e)
        {
            CleanTextBoxes(3);
        }

        private void languageTextBox_Click(object sender, EventArgs e)
        {
            CleanTextBoxes(4);
        }

        private void genreTextBox_Click(object sender, EventArgs e)
        {
            CleanTextBoxes(5);
        }

        private void budgetTextBox_Click(object sender, EventArgs e)
        {
            CleanTextBoxes(6);
        }
    }
}
