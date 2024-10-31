using CleanLibrary.Domain.Enums;

namespace CleanLibrary.Domain.Common
{
    internal class BookTypeFee
    {
        public readonly BookType BookType;
        public readonly decimal RentFee;

        public BookTypeFee(BookType bookType, decimal rentFee)
        {
            BookType = bookType;
            RentFee = rentFee;  
        }
    }
}
