using Data_Access;

namespace Business_Logic
{
    public class PairModel
    {
        public int PairId { get; set; }
        public string PairName { get; set; }

        public static PairModel Parse(MediaDS.TabGenreRow genreRow)
        {
            if (genreRow == null)
                return null;

            PairModel pair = new PairModel
            {
                PairId = genreRow.GID,
                PairName = genreRow.GenreName
            };

            return pair;
        }

        public static PairModel Parse(MediaDS.TabDirectorRow directorRow)
        {
            if (directorRow == null)
                return null;

            PairModel pair = new PairModel
            {
                PairId = directorRow.DID,
                PairName = directorRow.DirectorName
            };

            return pair;
        }

        public static PairModel Parse(MediaDS.TabLanguageRow languageRow)
        {
            if (languageRow == null)
                return null;

            PairModel pair = new PairModel
            {
                PairId = languageRow.LID,
                PairName = languageRow.LanguageName
            };

            return pair;
        }
    }
}
