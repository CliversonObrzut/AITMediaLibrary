using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Business_Logic;

namespace AITMediaLibrary
{
    public partial class AdminMediaForm : Form
    {
        private readonly MediaLogic _mediaLogic;

        private MediaModel _selectedMedia;

        public AdminMediaForm()
        {
            InitializeComponent();
            _mediaLogic = new MediaLogic();
        }

        private void AdminMedia_Load(object sender, EventArgs e)
        {
            try
            {
                loggedInUserLabel.Text = @"User:  " + CurrentUser.UserName;
                loggedInLevelLabel.Text = @"Level:  " + CurrentUser.UserLevel;
                FillGenreComboBox();
                FillDirectorComboBox();
                FillLanguageComboBox();
                RefresMediaList();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Error loading Media Admin!");
            }
        }

        private void RefresMediaList()
        {
            List<MediaModel> medias = _mediaLogic.ListMedia();
            mediaGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mediaGridView.DataSource = medias;
            SelectedMediaOnLoad(medias);
            CleanTextBoxes();
        }

        private void SelectedMediaOnLoad(List<MediaModel> medias)
        {
            MediaModel media = medias[0];
            _selectedMedia = media;
            selectedMediaLabel.Text = @"Selected Media:  " + media.MediaName;
        }

        private void mediaGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > -1)
            {
                List<MediaModel> medias = (List<MediaModel>)mediaGridView.DataSource;

                _selectedMedia = medias.ElementAt(row);
                selectedMediaLabel.Text = @"Selected Media:  " + _selectedMedia.MediaName;
            }
        }

        private void listAllButton_Click(object sender, EventArgs e)
        {
            RefresMediaList();
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(OpenAddGenre);
            t.Start();
            while (t.IsAlive)
            {
                
            }
            FillGenreComboBox();
        }

        private static void OpenAddGenre()
        {
            Application.Run(new AddGenreForm());
        }

        private void addLanguageButton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(OpenAddLanguage);
            t.Start();
            while (t.IsAlive)
            {

            }
            FillLanguageComboBox();
        }

        private static void OpenAddLanguage()
        {
            Application.Run(new AddLanguageForm());
        }

        private void addDirectorButton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(OpenAddDirector);
            t.Start();
            while (t.IsAlive)
            {

            }
            FillDirectorComboBox();
        }

        private static void OpenAddDirector()
        {
            Application.Run(new AddDirectorForm());
        }

        private void FillGenreComboBox()
        {
            genreComboBox.DataSource = _mediaLogic.ListGenre();
            genreComboBox.ValueMember = "PairID";
            genreComboBox.DisplayMember = "PairName";
        }

        private void FillDirectorComboBox()
        {
            directorComboBox.DataSource = _mediaLogic.ListDirector();
            directorComboBox.ValueMember = "PairID";
            directorComboBox.DisplayMember = "PairName";
        }

        private void FillLanguageComboBox()
        {
            languageComboBox.DataSource = _mediaLogic.ListLanguage();
            languageComboBox.ValueMember = "PairID";
            languageComboBox.DisplayMember = "PairName";
        }

        private void userAdminButton_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(OpenUserAdmin);
            t.Start();
            Close();
        }

        private static void OpenUserAdmin()
        {
            Application.Run(new AdminUserForm());
        }

        private void addMediaButton_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text != "" && publishYearTextBox.Text != "" && budgetTextBox.Text != "")
            {
                try
                {
                    _mediaLogic.AddNewMedia(titleTextBox.Text,
                                  int.Parse(genreComboBox.SelectedValue.ToString()),
                                  int.Parse(directorComboBox.SelectedValue.ToString()),
                                  int.Parse(languageComboBox.SelectedValue.ToString()),
                                  int.Parse(publishYearTextBox.Text),
                                  decimal.Parse(budgetTextBox.Text));
                    MessageBox.Show(@"New media successfully created!");
                    RefresMediaList();
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Media creation failed! Check the values and try again!");
                }
            }
            else
            {
                MessageBox.Show(@"Missing information!");
            }
        }

        private bool IsBorrowedOrReserved()
        {
            ReserveModel reserve = _mediaLogic.GetReserveByMediaID(_selectedMedia.MediaId);
            BorrowModel borrow = _mediaLogic.GetBorrowedByMedia(_selectedMedia.MediaId);
            if (reserve != null || borrow != null)
                return true;
            return false;
        }

        private void deleteMediaButton_Click(object sender, EventArgs e)
        {
            if (_selectedMedia != null)
            {
                if (IsBorrowedOrReserved())
                {
                    MessageBox.Show(@"Not possible to delete because this media is borrowed or reserved");
                }
                else
                {
                    _mediaLogic.DeleteMedia(_selectedMedia.MediaId);
                    _selectedMedia = null;
                    MessageBox.Show(@"Selected media successfully deleted!");
                    RefresMediaList();
                }
            }
            else
                MessageBox.Show(@"Error deleting media!");
        }

        private void updateSelectedMediaButton_Click(object sender, EventArgs e)
        {
            SetUpdateMediaBackground(Color.CadetBlue);
            updateSelectedMediaButton.Visible = false;
            addMediaButton.Visible = false;
            addNewMediaLabel.Text = @"Update Media:";
            GetSelectedMediaValuesToUpdate();
        }

        private void updateMediaButton_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text != "" && publishYearTextBox.Text != "" && budgetTextBox.Text != "")
            {
                try
                {
                    _mediaLogic.UpdateMedia(
                        titleTextBox.Text,
                        int.Parse(genreComboBox.SelectedValue.ToString()),
                        int.Parse(directorComboBox.SelectedValue.ToString()),
                        int.Parse(languageComboBox.SelectedValue.ToString()),
                        int.Parse(publishYearTextBox.Text),
                        decimal.Parse(budgetTextBox.Text),
                        _selectedMedia.MediaId);

                    SetUpdateMediaBackground(Color.DimGray);
                    updateSelectedMediaButton.Visible = true;
                    addMediaButton.Visible = true;
                    addNewMediaLabel.Text = @"Add New Media:";
                    CleanTextBoxes();
                    RefresMediaList();
                    MessageBox.Show(@"Selected media successfully updated!");
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Media update failed! Check the values and try again!");
                }
            }
            else
            {
                MessageBox.Show(@"Missing information!");
            }
        }

        private void cancelUpdateModeButton_Click(object sender, EventArgs e)
        {
            SetUpdateMediaBackground(Color.DimGray);
            updateSelectedMediaButton.Visible = true;
            addMediaButton.Visible = true;
            addNewMediaLabel.Text = @"Add New Media:";
            CleanTextBoxes();
        }

        private void GetSelectedMediaValuesToUpdate()
        {
            titleTextBox.Text = _selectedMedia.MediaName;
            publishYearTextBox.Text = _selectedMedia.PublishYear.ToString();
            budgetTextBox.Text = _selectedMedia.Budget.ToString(CultureInfo.CurrentCulture);
            genreComboBox.SelectedIndex = genreComboBox.FindString(_selectedMedia.Genre);
            directorComboBox.SelectedIndex = directorComboBox.FindString(_selectedMedia.DirectorName);
            languageComboBox.SelectedIndex = languageComboBox.FindString(_selectedMedia.Language);
        }

        private void SetUpdateMediaBackground(Color color)
        {
            updateMediaGridView.BackgroundColor = color;
            addNewMediaGridView.BackgroundColor = color;
            titleLabel.BackColor = color;
            genreLabel.BackColor = color;
            directorLabel.BackColor = color;
            languageLabel.BackColor = color;
            publishYearLabel.BackColor = color;
            budgetLabel.BackColor = color;
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

        private void searchMediaButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<MediaModel> medias = _mediaLogic.ListMediaByTitle(searchMediaTextBox.Text);
                mediaGridView.DataSource = medias;
                SelectedMediaOnLoad(medias);
                CleanTextBoxes();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Media(s) not found!");
                RefresMediaList();
            }
        }

        private void CleanTextBoxes(int num = 0)
        {
            if (num != 1)
                searchMediaTextBox.Text = "";
            if (num != 2)
            {
                titleTextBox.Text = "";
                publishYearTextBox.Text = "";
                budgetTextBox.Text = "";
                FillLanguageComboBox();
                FillDirectorComboBox();
                FillGenreComboBox();
            }
        }

        private void reservedMediaButton_Click(object sender, EventArgs e)
        {
            List<MediaModel> medias = _mediaLogic.GetAllReserves();
            mediaGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mediaGridView.DataSource = medias;
            SelectedMediaOnLoad(medias);
            CleanTextBoxes();
        }

        private void borrowedButton_Click(object sender, EventArgs e)
        {
            List<MediaModel> medias = _mediaLogic.GetAllBorrowed();
            mediaGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mediaGridView.DataSource = medias;
            SelectedMediaOnLoad(medias);
            CleanTextBoxes();
        }
    }
}
