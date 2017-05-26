using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Data_Access;

namespace Business_Logic
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class MediaLogic
    {
        private readonly MediaDAO _mediaDao;

        private const decimal FeePerDayLate = 0.5m;

        public MediaLogic()
        {
            _mediaDao = new MediaDAO();
        }

        /// <summary>
        /// Returns all medias as a list of media models.
        /// </summary>
        /// <returns></returns>
        public List<MediaModel> ListMedia()
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = _mediaDao.ListMedia();

            GetListOfMediasFromDataTable(mediaTable, medias);
            return medias;
        }

        /// <summary>
        /// Returns a list of medias by publish year as media models.
        /// </summary>
        /// <param name="publishYear"></param>
        /// <returns></returns>
        public List<MediaModel> ListMediaByPublishYear(int publishYear)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = _mediaDao.ListMediaByPublishYear(publishYear);

            GetListOfMediasFromDataTable(mediaTable, medias);
            return medias;
        }

        /// <summary>
        /// Returns a list of medias by director name as media models.
        /// </summary>
        /// <param name="directorName"></param>
        /// <returns></returns>
        public List<MediaModel> ListMediaByDirectorName(string directorName)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = _mediaDao.ListMediaByDirectorName(directorName);

            GetListOfMediasFromDataTable(mediaTable, medias);
            return medias;
        }

        /// <summary>
        /// Returns a list of medias by title as media models.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public List<MediaModel> ListMediaByTitle(string title)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = _mediaDao.ListMediaByTitle(title);

            GetListOfMediasFromDataTable(mediaTable, medias);
            return medias;
        }

        /// <summary>
        /// Returns a list of medias by language as media models.
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        public List<MediaModel> ListMediaByLanguage(string language)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = _mediaDao.ListMediaByLanguage(language);

            GetListOfMediasFromDataTable(mediaTable, medias);
            return medias;
        }

        /// <summary>
        /// Returns a list of medias by genre as media models.
        /// </summary>
        /// <param name="genre"></param>
        /// <returns></returns>
        public List<MediaModel> ListMediaByGenre(string genre)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = _mediaDao.ListMediaByGenre(genre);

            GetListOfMediasFromDataTable(mediaTable, medias);
            return medias;
        }

        /// <summary>
        /// Returns a list of medias by budget as media models.
        /// </summary>
        /// <param name="budget"></param>
        /// <returns></returns>
        public List<MediaModel> ListMediaByBudget(decimal budget)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = _mediaDao.ListMediaByBudget(budget);

            GetListOfMediasFromDataTable(mediaTable, medias);
            return medias;
        }

        /// <summary>
        /// Retursn all genre as a list of pair models.
        /// </summary>
        /// <returns></returns>
        public List<PairModel> ListGenre()
        {
            List<PairModel> pairs = new List<PairModel>();
            MediaDS.TabGenreDataTable genreTable = _mediaDao.ListGenre();

            foreach (MediaDS.TabGenreRow row in genreTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                pairs.Add(pair);
            }
            return pairs;
        }

        /// <summary>
        /// Returns all directors as a list of pair models.
        /// </summary>
        /// <returns></returns>
        public List<PairModel> ListDirector()
        {
            List<PairModel> pairs = new List<PairModel>();
            MediaDS.TabDirectorDataTable directorTable = _mediaDao.ListDirector();

            foreach (MediaDS.TabDirectorRow row in directorTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                pairs.Add(pair);
            }
            return pairs;
        }

        /// <summary>
        /// Returns all languages as a list of pair models.
        /// </summary>
        /// <returns></returns>
        public List<PairModel> ListLanguage()
        {
            List<PairModel> pairs = new List<PairModel>();
            MediaDS.TabLanguageDataTable languageTable = _mediaDao.ListLanguage();

            foreach (MediaDS.TabLanguageRow row in languageTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                pairs.Add(pair);
            }
            return pairs;
        }

        /// <summary>
        /// Add a new genre to Database.
        /// </summary>
        /// <param name="genreName"></param>
        /// <returns></returns>
        public int AddNewGenre(string genreName)
        {
            return _mediaDao.AddGenre(genreName);
        }

        /// <summary>
        /// Add a new language to Database.
        /// </summary>
        /// <param name="languageName"></param>
        /// <returns></returns>
        public int AddNewLanguage(string languageName)
        {
            return _mediaDao.AddLanguage(languageName);
        }

        /// <summary>
        /// Add a new director to Database.
        /// </summary>
        /// <param name="directorName"></param>
        /// <returns></returns>
        public int AddNewDirector(string directorName)
        {
            return _mediaDao.AddDirector(directorName);
        }

        /// <summary>
        /// Add a new media to Database.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="genreID"></param>
        /// <param name="directorID"></param>
        /// <param name="languageID"></param>
        /// <param name="publishYear"></param>
        /// <param name="budget"></param>
        /// <returns></returns>
        public int AddNewMedia(string title, int genreID, int directorID, int languageID, int publishYear,
            decimal budget)
        {
            return _mediaDao.AddMedia(title, genreID, directorID, languageID, publishYear, budget);
        }

        /// <summary>
        /// Update a selected media in Database. 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="genreID"></param>
        /// <param name="directorID"></param>
        /// <param name="languageID"></param>
        /// <param name="publishYear"></param>
        /// <param name="budget"></param>
        /// <param name="mediaID"></param>
        /// <returns></returns>
        public int UpdateMedia(string title, int genreID, int directorID, int languageID, int publishYear, decimal budget, int mediaID)
        {
            return _mediaDao.UpdateMedia(mediaID, title, genreID, directorID, languageID, publishYear, budget);
        }

        /// <summary>
        /// Delete a media from Database.
        /// </summary>
        /// <param name="mediaID"></param>
        /// <returns></returns>
        public int DeleteMedia(int mediaID)
        {
            return _mediaDao.DeleteMedia(mediaID);
        }

        /// <summary>
        /// Returns a reserve by media as a reserve model.
        /// </summary>
        /// <param name="mediaID"></param>
        /// <returns></returns>
        public ReserveModel GetReserveByMediaID(int mediaID)
        {
            MediaDS.TabReservedDataTable reserveTable = _mediaDao.GetReservedByMedia(mediaID);
            ReserveModel reserve = null;
            if (reserveTable.Rows.Count != 0)
                reserve = ReserveModel.Parse(reserveTable[0]);
            return reserve;
        }

        /// <summary>
        /// Returns a reserve by user as a reserve model.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public ReserveModel GetReservedByUser(int userID)
        {
            MediaDS.TabReservedDataTable reserveTable = _mediaDao.GetReservedByUser(userID);
            ReserveModel reserve = null;
            if (reserveTable.Rows.Count != 0)
                reserve = ReserveModel.Parse(reserveTable[0]);
            return reserve;
        }

        /// <summary>
        /// Returns the list of reserved medias as media models
        /// </summary>
        /// <returns></returns>
        public List<MediaModel> GetAllReserves()
        {
            MediaDS.TabReservedDataTable reserveTable = _mediaDao.GetAllReserves();
            List<MediaModel> medias = new List<MediaModel>();
            foreach (MediaDS.TabReservedRow row in reserveTable)
            {
                MediaDS.ViewMediaDataTable mediaDS = _mediaDao.GetMediaById(row.MediaID);
                MediaDS.ViewMediaRow mediaDSRow = mediaDS[0];
                MediaModel media = MediaModel.Parse(mediaDSRow);
                medias.Add(media);
            }
            return medias;
        }

        /// <summary>
        /// Add a nre reserve to Database
        /// </summary>
        /// <param name="mediaID"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public int AddReserve(int mediaID, int userID)
        {
            return _mediaDao.AddReserve(mediaID, userID, DateTime.Now.ToString("dd/MM/yyyy"));
        }

        /// <summary>
        /// Delete a selected media from database.
        /// </summary>
        /// <param name="RID"></param>
        /// <returns></returns>
        public int DeleteReserve(int RID)
        {
            return _mediaDao.DeleteReserve(RID);
        }

        /// <summary>
        /// Returns the list of medias currently borrowed by a specific user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<MediaModel> GetBorrowedByUser(int userId)
        {
            MediaDS.TabBorrowDataTable borrowTable = _mediaDao.GetBorrowsByUser(userId);
            List<MediaModel> medias = new List<MediaModel>();
            foreach (MediaDS.TabBorrowRow row in borrowTable)
            {
                BorrowModel borrow = BorrowModel.Parse(row);
                if (borrow.IsActive())
                {
                    MediaDS.ViewMediaDataTable mediaDS = _mediaDao.GetMediaById(row.MediaID);
                    MediaDS.ViewMediaRow mediaDSRow = mediaDS[0];
                    MediaModel media = MediaModel.Parse(mediaDSRow);
                    medias.Add(media);
                }
            }
            return medias;
        }

        /// <summary>
        /// Returns a borrow by media if its currently borrowed.
        /// </summary>
        /// <param name="mediaID"></param>
        /// <returns></returns>
        public BorrowModel GetBorrowedByMedia(int mediaID)
        {
            MediaDS.TabBorrowDataTable borrowTable = _mediaDao.GetBorrowedByMedia(mediaID);
            List<BorrowModel> borrows = new List<BorrowModel>();
            foreach (MediaDS.TabBorrowRow row in borrowTable)
            {
                BorrowModel borrowDB = BorrowModel.Parse(row);
                if(borrowDB.IsActive())
                    borrows.Add(borrowDB);
            }
            BorrowModel borrow = null;
            if (borrows.Count > 0)
                borrow = borrows[0];
            return borrow;
        }

        /// <summary>
        /// Returns a borrow by id as borrow model.
        /// </summary>
        /// <param name="borrowID"></param>
        /// <returns></returns>
        public BorrowModel GetBorrowById(int borrowID)
        {
            MediaDS.TabBorrowDataTable borrowTable = _mediaDao.GetBorrowById(borrowID);
            BorrowModel borrow = null;
            if (borrowTable.Rows.Count != 0)
                borrow = BorrowModel.Parse(borrowTable[0]);

            return borrow;
        }

        /// <summary>
        /// Returns the list of all currently borrowed medias.
        /// </summary>
        /// <returns></returns>
        public List<MediaModel> GetAllBorrowed()
        {
            MediaDS.TabBorrowDataTable borrowTable = _mediaDao.GetAllBorrows();
            List<MediaModel> medias = new List<MediaModel>();
            foreach (MediaDS.TabBorrowRow row in borrowTable)
            {
                BorrowModel borrow = BorrowModel.Parse(row);
                if (borrow.IsActive())
                {
                    MediaDS.ViewMediaDataTable mediaDS = _mediaDao.GetMediaById(row.MediaID);
                    MediaDS.ViewMediaRow mediaDSRow = mediaDS[0];
                    MediaModel media = MediaModel.Parse(mediaDSRow);
                    medias.Add(media);
                }
            }
            return medias;
        }

        /// <summary>
        /// Add a new borrow to Database.
        /// </summary>
        /// <param name="mediaID"></param>
        /// <param name="userID"></param>
        /// <returns></returns>
        public int AddBorrow(int mediaID, int userID)
        {
            return _mediaDao.AddBorrow(userID, mediaID, DateTime.Now.ToString("dd/MM/yyyy"),(DateTime.Now.AddDays(7)).ToString("dd/MM/yyyy"));
        }

        /// <summary>
        /// Update the borrow data in database when a media is returned and the borrow is closed. 
        /// Also, it calculates the fee if the return is late.
        /// </summary>
        /// <param name="BID"></param>
        /// <returns></returns>
        public int ReturnBorrow(int BID)
        {
            decimal lateFee = 0;
            BorrowModel borrow = GetBorrowById(BID);
            
            if (DateTime.Now > borrow.ReturnDate)
            {
                TimeSpan daysLate = DateTime.Now - borrow.BorrowDate;
                lateFee = daysLate.Days * FeePerDayLate;
            }

            return _mediaDao.updateBorrow(BID, DateTime.Now.ToString("dd/MM/yyyy"), lateFee);
        }

        /// <summary>
        /// Binds a list of medias from Database to a list of media models.
        /// </summary>
        /// <param name="mediaTable"></param>
        /// <param name="medias"></param>
        private static void GetListOfMediasFromDataTable(MediaDS.ViewMediaDataTable mediaTable, List<MediaModel> medias)
        {
            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
        }

        /// <summary>
        /// Return a list of medias that matches the value in columns Title, Director, Genre, Language, Publish Year and Budget
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        // 
        public List<MediaModel> GetAllThatMatches(string search)
        {
            List<MediaModel> medias = new List<MediaModel>();

            List<MediaModel> mediasPublishYear = new List<MediaModel>();
            List<MediaModel> mediasBudget = new List<MediaModel>();
            var mediasTitle = ListMediaByTitle(search);
            var mediasDirector = ListMediaByDirectorName(search);
            var mediasGenre = ListMediaByGenre(search);
            var mediasLanguage = ListMediaByLanguage(search);

            int publishYear;
            decimal budget;

            if (int.TryParse(search, out publishYear))
            {
                publishYear = int.Parse(search);
                mediasPublishYear = ListMediaByPublishYear(publishYear);
            }
            if (decimal.TryParse(search, out budget))
            {
                budget = decimal.Parse(search);
                mediasBudget = ListMediaByBudget(budget);
            }

            if (mediasTitle.Count > 0)
            {
                foreach (MediaModel media in mediasTitle)
                {
                    if (medias.Contains(media) == false)
                        medias.Add(media);
                }
            }

            if (mediasDirector.Count > 0)
            {
                foreach (MediaModel media in mediasDirector)
                {
                    if (medias.All(o => o.MediaId != media.MediaId))
                        medias.Add(media);
                }
            }

            if (mediasGenre.Count > 0)
            {
                foreach (MediaModel media in mediasGenre)
                {
                    if (medias.All(o => o.MediaId != media.MediaId))
                        medias.Add(media);
                }
            }

            if (mediasLanguage.Count > 0)
            {
                foreach (MediaModel media in mediasLanguage)
                {
                    if (medias.All(o => o.MediaId != media.MediaId))
                        medias.Add(media);
                }
            }

            if (mediasPublishYear.Count > 0)
            {
                foreach (MediaModel media in mediasPublishYear)
                {
                    if (medias.All(o => o.MediaId != media.MediaId))
                        medias.Add(media);
                }
            }

            if (mediasBudget.Count > 0)
            {
                foreach (MediaModel media in mediasBudget)
                {
                    if (medias.All(o => o.MediaId != media.MediaId))
                        medias.Add(media);
                }
            }

            medias = medias.OrderBy(o => o.MediaId).ToList();
            return medias;
        }
    }
}
