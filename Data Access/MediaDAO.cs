using System;
using System.Diagnostics.CodeAnalysis;
using Data_Access.MediaDSTableAdapters;

namespace Data_Access
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class MediaDAO
    {
        private MediaDS _mediaDataSet;
        private readonly ViewMediaTableAdapter _viewMediaTableAdapter;
        private TabMediaTableAdapter _mediaTableAdapter;
        private TabLanguageTableAdapter _languageTableAdapter;
        private TabGenreTableAdapter _genreTableAdapter;
        private TabDirectorTableAdapter _directorTableAdapter;
        private TabReservedTableAdapter _reserveTableAdapter;
        private TabBorrowTableAdapter _borrowTableAdapter;

        public MediaDAO()
        {
            _mediaDataSet = new MediaDS();
            _viewMediaTableAdapter = new ViewMediaTableAdapter();
            _languageTableAdapter = new TabLanguageTableAdapter();
            _genreTableAdapter = new TabGenreTableAdapter();
            _directorTableAdapter = new TabDirectorTableAdapter();
            _mediaTableAdapter = new TabMediaTableAdapter();
            _reserveTableAdapter = new TabReservedTableAdapter();
            _borrowTableAdapter = new TabBorrowTableAdapter();
        }

        public MediaDS.ViewMediaDataTable ListMedia()
        {
            try
            {
                _viewMediaTableAdapter.Fill(_mediaDataSet.ViewMedia);
                return _mediaDataSet.ViewMedia;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public MediaDS.ViewMediaDataTable ListMediaByPublishYear(int publishYear)
        {
            try
            {
                _viewMediaTableAdapter.FillByPublishYear(_mediaDataSet.ViewMedia, publishYear);
                return _mediaDataSet.ViewMedia;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public MediaDS.ViewMediaDataTable ListMediaByDirectorName(string directorName)
        {
            try
            {
                _viewMediaTableAdapter.FillByDirectorName(_mediaDataSet.ViewMedia, directorName);
                return _mediaDataSet.ViewMedia;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public MediaDS.ViewMediaDataTable ListMediaByGenre(string genre)
        {
            try
            {
                _viewMediaTableAdapter.FillByGenre(_mediaDataSet.ViewMedia, genre);
                return _mediaDataSet.ViewMedia;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public MediaDS.ViewMediaDataTable ListMediaByLanguage(string language)
        {
            try
            {
                _viewMediaTableAdapter.FillByLanguage(_mediaDataSet.ViewMedia, language);
                return _mediaDataSet.ViewMedia;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public MediaDS.ViewMediaDataTable ListMediaByTitle(string title)
        {
            try
            {
                _viewMediaTableAdapter.FillByTitle(_mediaDataSet.ViewMedia, title);
                return _mediaDataSet.ViewMedia;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public MediaDS.ViewMediaDataTable ListMediaByBudget(decimal budget)
        {
            try
            {
                _viewMediaTableAdapter.FillByBudget(_mediaDataSet.ViewMedia, budget);
                return _mediaDataSet.ViewMedia;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public MediaDS.TabLanguageDataTable ListLanguage()
        {
            try
            {
                _languageTableAdapter.Fill(_mediaDataSet.TabLanguage);
                return _mediaDataSet.TabLanguage;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public MediaDS.TabDirectorDataTable ListDirector()
        {
            try
            {
                _directorTableAdapter.Fill(_mediaDataSet.TabDirector);
                return _mediaDataSet.TabDirector;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public MediaDS.TabGenreDataTable ListGenre()
        {
            try
            {
                _genreTableAdapter.Fill(_mediaDataSet.TabGenre);
                return _mediaDataSet.TabGenre;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int AddGenre(string genreName)
        {
            return _genreTableAdapter.AddGenre(genreName);
        }

        public int AddLanguage(string languageName)
        {
            return _languageTableAdapter.AddLanguage(languageName);
        }

        public int AddDirector(string directorName)
        {
            return _directorTableAdapter.AddDirector(directorName);
        }

        public int AddMedia(string title, int genreID, int directorID, int languageID, int publishYear, decimal budget)
        {
            return _mediaTableAdapter.AddMedia(title, genreID, directorID, languageID, publishYear, budget);
        }

        public int UpdateMedia(int mediaID, string title, int genreID, int directorID, int languageID, int publishYear, decimal budget)
        {
            return _mediaTableAdapter.UpdateMedia(title, genreID, directorID, languageID, publishYear, budget, mediaID);
        }

        public int DeleteMedia(int mediaID)
        {
            return _mediaTableAdapter.DeleteMedia(mediaID);
        }

        public MediaDS.TabReservedDataTable GetReserveByMedia(int mediaID)
        {
            try
            {
                _reserveTableAdapter.FillByMediaID(_mediaDataSet.TabReserved, mediaID);
                return _mediaDataSet.TabReserved;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int AddReserve(int mediaID, int userID, string date)
        {
            return _reserveTableAdapter.AddReserve(userID, mediaID, date);
        }

        public int DeleteReserve(int RID)
        {
            return _reserveTableAdapter.DeleteReserve(RID);
        }

        public MediaDS.TabBorrowDataTable GetBorrowByUserAndMedia(int userID, int mediaID)
        {
            try
            {
                _borrowTableAdapter.FillByUserMedia(_mediaDataSet.TabBorrow, userID, mediaID);
                return _mediaDataSet.TabBorrow;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public MediaDS.TabBorrowDataTable GetBorrowed(string actualReturnDate)
        {
            try
            {
                _borrowTableAdapter.FillByBorrowed(_mediaDataSet.TabBorrow, actualReturnDate);
                return _mediaDataSet.TabBorrow;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int AddBorrow(int userID, int mediaID, string borrowDate, string returnDate)
        {
            return _borrowTableAdapter.AddBorrow(userID, mediaID, borrowDate, returnDate);
        }

        public int updateBorrow(int borrowID, string actualReturnDate, decimal LateFee)
        {
            return _borrowTableAdapter.UpdateBorrow(actualReturnDate, LateFee, borrowID);
        }
    }
}
