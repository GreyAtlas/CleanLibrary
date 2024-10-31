using CleanLibrary.Domain.Enums;

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
