using System.ComponentModel;
using Data_Access;

namespace Business_Logic
{
    public class MediaModel
    {
        [DisplayName("Media Id")]
        public int MediaId { get; set; }

        [DisplayName("Media Name")]
        public string MediaName { get; set; }

        [DisplayName("Publish Year")]
        public int PublishYear { get; set; }

        [DisplayName("Director Name")]
        public string DirectorName { get; set; }
        public string Language { get; set; }
        public string Genre { get; set; }
        public decimal Budget { get; set; }

        public static MediaModel Parse(MediaDS.ViewMediaRow mediaRow)
        {
            if (mediaRow == null)
                return null;

            var media = new MediaModel
            {
                MediaId = mediaRow.MediaID,
                MediaName = mediaRow.Title,
                PublishYear = mediaRow.PublishYear,
                DirectorName = mediaRow.DirectorName,
                Language = mediaRow.LanguageName,
                Genre = mediaRow.GenreName,
                Budget = mediaRow.Budget
            };

            return media;
        }
    }
}
