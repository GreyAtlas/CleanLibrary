using CleanLibrary.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLibrary.Application.Features.Books
{
    public class BookSearchTermsDTO
    {
        public string? Name { get; set; }
        public int? PublishingDate { get; set; }

        //public byte[] Picture { get; set; }

        public List<BookType>? AvailableBookTypes { get; set; }
    }
}
