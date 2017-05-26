using System;
using System.Diagnostics.CodeAnalysis;
using Data_Access.MediaDSTableAdapters;

namespace Data_Access
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class MediaDAO
    {
        
        private readonly MediaDS _mediaDataSet;
        private readonly ViewMediaTableAdapter _viewMediaTableAdapter;
        private readonly TabMediaTableAdapter _mediaTableAdapter;
        private readonly TabLanguageTableAdapter _languageTableAdapter;
        private readonly TabGenreTableAdapter _genreTableAdapter;
        private readonly TabDirectorTableAdapter _directorTableAdapter;
        private readonly TabReservedTableAdapter _reserveTableAdapter;
        private readonly TabBorrowTableAdapter _borrowTableAdapter;

        /// <summary>
        /// MediaDAO constructor
        /// </summary>
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

        /// <summary>
        /// Returns all media from Database
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Returns media by id
        /// </summary>
        /// <param name="mediaID"></param>
        /// <returns></returns>
        public MediaDS.ViewMediaDataTable GetMediaById(int mediaID)
        {
            try
            {
                _viewMediaTableAdapter.FillByMediaId(_mediaDataSet.ViewMedia, mediaID);
                return _mediaDataSet.ViewMedia;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Returns medias by publish year.
        /// </summary>
        /// <param name="publishYear"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns medias by director name. It can be a partial name.
        /// </summary>
        /// <param name="directorName"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns medias by genre. It can be a partial name.
        /// </summary>
        /// <param name="genre"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns medias by language name. It can be a partial name.
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns medias by title. It can be a partial name.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns medias by budget
        /// </summary>
        /// <param name="budget"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns all languages from Database.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Returns all directors from Database.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Returns all genre from Database.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Add new genre to Database.
        /// </summary>
        /// <param name="genreName"></param>
        /// <returns></returns>
        public int AddGenre(string genreName)
        {
            return _genreTableAdapter.AddGenre(genreName);
        }

        /// <summary>
        /// Add new language to Database.
        /// </summary>
        /// <param name="languageName"></param>
        /// <returns></returns>
        public int AddLanguage(string languageName)
        {
            return _languageTableAdapter.AddLanguage(languageName);
        }

        /// <summary>
        /// Add new director to Database.
        /// </summary>
        /// <param name="directorName"></param>
        /// <returns></returns>
        public int AddDirector(string directorName)
        {
            return _directorTableAdapter.AddDirector(directorName);
        }

        /// <summary>
        /// Add new media to Database.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="genreID"></param>
        /// <param name="directorID"></param>
        /// <param name="languageID"></param>
        /// <param name="publishYear"></param>
        /// <param name="budget"></param>
        /// <returns></returns>
        public int AddMedia(string title, int genreID, int directorID, int languageID, int publishYear, decimal budget)
        {
            return _mediaTableAdapter.AddMedia(title, genreID, directorID, languageID, publishYear, budget);
        }

        /// <summary>
        /// Update a selected media in Database.
        /// </summary>
        /// <param name="mediaID"></param>
        /// <param name="title"></param>
        /// <param name="genreID"></param>
        /// <param name="directorID"></param>
        /// <param name="languageID"></param>
        /// <param name="publishYear"></param>
        /// <param name="budget"></param>
        /// <returns></returns>
        public int UpdateMedia(int mediaID, string title, int genreID, int directorID, int languageID, int publishYear, decimal budget)
        {
            return _mediaTableAdapter.UpdateMedia(title, genreID, directorID, languageID, publishYear, budget, mediaID);
        }

        /// <summary>
        /// Delete a selected media from Database.
        /// </summary>
        /// <param name="mediaID"></param>
        /// <returns></returns>
        public int DeleteMedia(int mediaID)
        {
            return _mediaTableAdapter.DeleteMedia(mediaID);
        }

        /// <summary>
        /// Returns reserve by media.
        /// </summary>
        /// <param name="mediaID"></param>
        /// <returns></returns>
        public MediaDS.TabReservedDataTable GetReservedByMedia(int mediaID)
        {
            try
            {
                _reserveTableAdapter.FillByMedia(_mediaDataSet.TabReserved, mediaID);
                return _mediaDataSet.TabReserved;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Returns all reserves by user
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public MediaDS.TabReservedDataTable GetReservedByUser(int userID)
        {
            try
            {
                _reserveTableAdapter.FillByUser(_mediaDataSet.TabReserved, userID);
                return _mediaDataSet.TabReserved;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Returns all reserves from Database.
        /// </summary>
        /// <returns></returns>
        public MediaDS.TabReservedDataTable GetAllReserves()
        {
            try
            {
                _reserveTableAdapter.Fill(_mediaDataSet.TabReserved);
                return _mediaDataSet.TabReserved;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Add a new reserve to Database.
        /// </summary>
        /// <param name="mediaID"></param>
        /// <param name="userID"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public int AddReserve(int mediaID, int userID, string date)
        {
            return _reserveTableAdapter.AddReserve(userID, mediaID, date);
        }

        /// <summary>
        /// Remove a reserve from Database.
        /// </summary>
        /// <param name="RID"></param>
        /// <returns></returns>
        public int DeleteReserve(int RID)
        {
            return _reserveTableAdapter.DeleteReserve(RID);
        }

        /// <summary>
        /// Returns all borrows from Database. (Actives and inactives)
        /// </summary>
        /// <returns></returns>
        public MediaDS.TabBorrowDataTable GetAllBorrows()
        {
            try
            {
                _borrowTableAdapter.Fill(_mediaDataSet.TabBorrow);
                return _mediaDataSet.TabBorrow;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Returns a borrow by id.
        /// </summary>
        /// <param name="BID"></param>
        /// <returns></returns>
        public MediaDS.TabBorrowDataTable GetBorrowById(int BID)
        {
            try
            {
                _borrowTableAdapter.FillByBorrowId(_mediaDataSet.TabBorrow, BID);
                return _mediaDataSet.TabBorrow;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Returns all borrows by media. Active and inactive.
        /// </summary>
        /// <param name="mediaID"></param>
        /// <returns></returns>

        public MediaDS.TabBorrowDataTable GetBorrowedByMedia(int mediaID)
        {
            try
            {
                _borrowTableAdapter.FillBorrowsByMedia(_mediaDataSet.TabBorrow, mediaID);
                return _mediaDataSet.TabBorrow;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Returns all medias by user. Active and Inactive.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public MediaDS.TabBorrowDataTable GetBorrowsByUser(int userID)
        {
            try
            {
                _borrowTableAdapter.FillBorrowsByUser(_mediaDataSet.TabBorrow, userID);
                return _mediaDataSet.TabBorrow;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Adds a new borrow to Database.
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="mediaID"></param>
        /// <param name="borrowDate"></param>
        /// <param name="returnDate"></param>
        /// <returns></returns>
        public int AddBorrow(int userID, int mediaID, string borrowDate, string returnDate)
        {
            return _borrowTableAdapter.AddBorrow(userID, mediaID, borrowDate, returnDate);
        }

        /// <summary>
        /// Updates a selected borrow.
        /// </summary>
        /// <param name="borrowID"></param>
        /// <param name="actualReturnDate"></param>
        /// <param name="LateFee"></param>
        /// <returns></returns>
        public int updateBorrow(int borrowID, string actualReturnDate, decimal LateFee)
        {
            return _borrowTableAdapter.UpdateBorrow(actualReturnDate, LateFee, borrowID);
        }
    }
}
