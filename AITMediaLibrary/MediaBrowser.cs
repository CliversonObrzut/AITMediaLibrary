﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business_Logic;

namespace AITMediaLibrary
{
    public partial class MediaBrowser : Form
    {
        private readonly MediaLogic _mediaLogic;

        public MediaBrowser()
        {
            _mediaLogic = new MediaLogic();
            InitializeComponent();
        }

        private void MediaBrowser_Load(object sender, EventArgs e)
        {
            try
            {
                List<MediaModel> medias = _mediaLogic.ListMedia();
                mediaGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                mediaGridView.DataSource = medias;
                userLabel.Text = @"Username: " + CurrentUser.UserName;
                levelLabel.Text = @"Level: " + CurrentUser.UserLevel;
                SelectedMediaOnLoad(medias);
                CleanTextBoxes();
            }
            catch (Exception)
            {
                errorDBLoadingLabel.Text = @"Sorry, It was not possible to load the data";
            }
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
            errorDBLoadingLabel.Text = "";
            MediaBrowser_Load(sender, e);
        }

        private void mediaGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                List<MediaModel> medias = (List<MediaModel>)mediaGridView.DataSource;
                MediaModel media = medias[row];

                selectedMediaLabel.Text = @"Selected Media: " + media.MediaName;
                errorDBLoadingLabel.Text = "";
            }
        }

        private void SelectedMediaOnLoad(List<MediaModel> medias)
        {
            MediaModel media = medias[0];
            selectedMediaLabel.Text = @"Selected Media: " + media.MediaName;
        }

        private void SearchErrorMessage()
        {
            errorDBLoadingLabel.Text = @"Sorry, the search doesn't match any value from database";
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
            if(num != 0)
                errorDBLoadingLabel.Text = "";
        }
    }
}