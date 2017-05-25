using System;
using System.Diagnostics.CodeAnalysis;
using Data_Access;

namespace Business_Logic
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class BorrowModel
    {
        public int BID { get; set; }
        public int UID { get; set; }
        public int MediaID { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime ActualReturnDate { get; set; }
        public decimal LateFee { get; set; }

        public static BorrowModel Parse(MediaDS.TabBorrowRow borrowRow)
        {
            if (borrowRow == null)
                return null;

            BorrowModel borrow = new BorrowModel()
            {
                BID = borrowRow.BID,
                UID = borrowRow.UID,
                MediaID = borrowRow.MediaID,
                BorrowDate = borrowRow.BorrowDate,
                ReturnDate = borrowRow.ReturnDate,
                ActualReturnDate = borrowRow.ActualReturnDate,
                LateFee = borrowRow.LateFee
            };

            return borrow;
        }

        public bool IsLate()
        {
            TimeSpan late = ActualReturnDate - ReturnDate;
            if (late.Days > 0)
                return true;
            return false;
        }

        public bool IsActive()
        {
            if (ActualReturnDate == DateTime.Parse("01/01/2000"))
                return true;
            return false;
        }
    }
}
