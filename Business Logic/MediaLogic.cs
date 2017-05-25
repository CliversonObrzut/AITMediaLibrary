using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

        public List<MediaModel> ListMedia()
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = _mediaDao.ListMedia();

            GetListOfMediasFromDataTable(mediaTable, medias);
            return medias;
        }

        public List<MediaModel> ListMediaByPublishYear(int publishYear)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = _mediaDao.ListMediaByPublishYear(publishYear);

            GetListOfMediasFromDataTable(mediaTable, medias);
            return medias;
        }

        public List<MediaModel> ListMediaByDirectorName(string directorName)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = _mediaDao.ListMediaByDirectorName(directorName);

            GetListOfMediasFromDataTable(mediaTable, medias);
            return medias;
        }

        public List<MediaModel> ListMediaByTitle(string title)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = _mediaDao.ListMediaByTitle(title);

            GetListOfMediasFromDataTable(mediaTable, medias);
            return medias;
        }

        public List<MediaModel> ListMediaByLanguage(string language)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = _mediaDao.ListMediaByLanguage(language);

            GetListOfMediasFromDataTable(mediaTable, medias);
            return medias;
        }

        public List<MediaModel> ListMediaByGenre(string genre)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = _mediaDao.ListMediaByGenre(genre);

            GetListOfMediasFromDataTable(mediaTable, medias);
            return medias;
        }

        public List<MediaModel> ListMediaByBudget(decimal budget)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = _mediaDao.ListMediaByBudget(budget);

            GetListOfMediasFromDataTable(mediaTable, medias);
            return medias;
        }

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

        public int AddNewGenre(string genreName)
        {
            return _mediaDao.AddGenre(genreName);
        }

        public int AddNewLanguage(string languageName)
        {
            return _mediaDao.AddLanguage(languageName);
        }
        public int AddNewDirector(string directorName)
        {
            return _mediaDao.AddDirector(directorName);
        }

        public int AddNewMedia(string title, int genreID, int directorID, int languageID, int publishYear,
            decimal budget)
        {
            return _mediaDao.AddMedia(title, genreID, directorID, languageID, publishYear, budget);
        }

        public int UpdateMedia(string title, int genreID, int directorID, int languageID, int publishYear, decimal budget, int mediaID)
        {
            return _mediaDao.UpdateMedia(mediaID, title, genreID, directorID, languageID, publishYear, budget);
        }

        public int DeleteMedia(int mediaID)
        {
            return _mediaDao.DeleteMedia(mediaID);
        }

        public ReserveModel GetReserveByMediaID(int mediaID)
        {
            MediaDS.TabReservedDataTable reserveTable = _mediaDao.GetReservedByMedia(mediaID);
            ReserveModel reserve = null;
            if (reserveTable.Rows.Count != 0)
                reserve = ReserveModel.Parse(reserveTable[0]);
            return reserve;
        }

        public ReserveModel GetReservedByUser(int userID)
        {
            MediaDS.TabReservedDataTable reserveTable = _mediaDao.GetReservedByUser(userID);
            ReserveModel reserve = null;
            if (reserveTable.Rows.Count != 0)
                reserve = ReserveModel.Parse(reserveTable[0]);
            return reserve;
        }

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

        public int AddReserve(int mediaID, int userID)
        {
            return _mediaDao.AddReserve(mediaID, userID, DateTime.Now.ToString("dd/MM/yyyy"));
        }

        public int DeleteReserve(int RID)
        {
            return _mediaDao.DeleteReserve(RID);
        }

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

        public BorrowModel GetBorrowById(int borrowID)
        {
            MediaDS.TabBorrowDataTable borrowTable = _mediaDao.GetBorrowById(borrowID);
            BorrowModel borrow = null;
            if (borrowTable.Rows.Count != 0)
                borrow = BorrowModel.Parse(borrowTable[0]);

            return borrow;
        }

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

        public int AddBorrow(int mediaID, int userID)
        {
            return _mediaDao.AddBorrow(userID, mediaID, DateTime.Now.ToString("dd/MM/yyyy"),(DateTime.Now.AddDays(7)).ToString("dd/MM/yyyy"));
        }

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

        private static void GetListOfMediasFromDataTable(MediaDS.ViewMediaDataTable mediaTable, List<MediaModel> medias)
        {
            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
        }
    }
}
