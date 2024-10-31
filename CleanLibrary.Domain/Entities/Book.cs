using CleanLibrary.Domain.Enums;

namespace CleanLibrary.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly PublishingDate { get; set; }
        public byte[] Picture { get; set; }

        public List<BookType> AvailableBookTypes { get; set; }

    }
}
