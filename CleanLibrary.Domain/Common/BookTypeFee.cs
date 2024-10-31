using CleanLibrary.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
