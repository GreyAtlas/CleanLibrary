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

        public Book(int id, string name, DateOnly publishingDate, byte[] picture, List<BookType> availableBookTypes)
        {
            Id = id;
            Name = name;
            PublishingDate = publishingDate;
            Picture = picture;
            AvailableBookTypes = availableBookTypes;
        }
    }
}
