using System;
using System.Collections.Generic;
using System.Linq;
using Data_Access;

namespace Business_Logic
{
    public class MediaLogic
    {
        private readonly MediaDAO _mediaDao;

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
            MediaDS.TabReservedDataTable reserveTable = _mediaDao.GetReserveByMedia(mediaID);
            ReserveModel reserve = null;
            if (reserveTable.Rows.Count != 0)
                reserve = ReserveModel.Parse(reserveTable[0]);

            return reserve;
        }

        public bool IsReserved(int mediaID)
        {
            ReserveModel reserve = GetReserveByMediaID(mediaID);

            if (reserve == null)
                return false;
            return true;
        }

        public int AddReserve(int mediaID, int userID)
        {
            return _mediaDao.AddReserve(mediaID, userID, DateTime.Now.ToString("dd/MM/yyyy"));
        }

        public int DeleteReserve(int RID)
        {
            return _mediaDao.DeleteReserve(RID);
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
