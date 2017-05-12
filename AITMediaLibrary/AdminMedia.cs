using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business_Logic;

namespace AITMediaLibrary
{
    public partial class AdminMedia : Form
    {
        private readonly MediaLogic _mediaLogic;
        public AdminMedia()
        {
            InitializeComponent();
            _mediaLogic = new MediaLogic();
        }

        private void AdminMedia_Load(object sender, EventArgs e)
        {
            FillGenreComboBox();
            FillDirectorComboBox();
            FillLanguageComboBox();

            try
            {
                List<MediaModel> medias = _mediaLogic.ListMedia();
                mediaGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                mediaGridView.DataSource = medias;
                //SelectedMediaOnLoad(medias);
                //CleanTextBoxes();
            }
            catch (Exception)
            {
                //errorDBLoadingLabel.Text = @"Sorry, It was not possible to load the data";
            }
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
            Application.Run(new AdminForm());
        }

        private void addMediaButton_Click(object sender, EventArgs e)
        {
            _mediaLogic.AddNewMedia(titleTextBox.Text, 
                                    int.Parse(genreComboBox.SelectedValue.ToString()), 
                                    int.Parse(directorComboBox.SelectedValue.ToString()), 
                                    int.Parse(languageComboBox.SelectedValue.ToString()), 
                                    int.Parse(publishYearTextBox.Text), 
                                    decimal.Parse(budgetTextBox.Text));
        }
    }
}
