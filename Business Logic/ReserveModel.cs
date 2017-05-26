using System;
using System.Diagnostics.CodeAnalysis;
using Data_Access;

namespace Business_Logic
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class ReserveModel
    {
        public int RID { get; set; }

        public int UID { get; set; }

        public int MediaID { get; set; }

        public DateTime ReservedDate { get; set; }

        /// <summary>
        /// Binds the reserve data from Database to reserve model.
        /// </summary>
        /// <param name="reserveRow"></param>
        /// <returns></returns>
        public static ReserveModel Parse(MediaDS.TabReservedRow reserveRow)
        {
            if (reserveRow == null)
                return null;

            var reserve = new ReserveModel()
            {
                RID = reserveRow.RID,
                UID = reserveRow.UID,
                MediaID = reserveRow.MediaID,
                ReservedDate = reserveRow.ReservedDate
            };

            return reserve;
        }

    }
}
