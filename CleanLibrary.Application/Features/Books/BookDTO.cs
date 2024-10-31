using CleanLibrary.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLibrary.Application.Features.Books
{
    public class BookDTO
    {
        public string Name {  get; set; }
        public DateOnly PublishingDate { get; set; }
        //public byte[] Picture { get; set; }

        public List<BookType> AvailableBookTypes { get; set; }
    }
}
