using CleanLibrary.Domain.Entities;
using CleanLibrary.Domain.Enums;

namespace CleanLibrary.Infrastructure.Data
{
    public class DataSeeding
    {
        public static async Task SeedInitialData(LibraryDataContext dataContext)
        {

            if (dataContext.Books.Any())
            {
                return;
            }
            var books = new List<Book>
            {
                new Book
                {
                    Name = "Knyga1",
                    PublishingDate = new DateOnly(2001,11,3),
                    Picture = System.IO.File.ReadAllBytes("Pictures/picture1.jpg"),
                    AvailableBookTypes = new List<BookType>{ BookType.Book, BookType.Audiobook}
                },
                new Book
                {
                    Name = "Knyga2",
                    PublishingDate = new DateOnly(2001, 11, 3),
                    Picture = System.IO.File.ReadAllBytes("Pictures/picture2.jpg"),
                    AvailableBookTypes = new List<BookType>{ BookType.Book}
                },
                new Book
                {
                    Name = "Knyga3",
                    PublishingDate = new DateOnly(2003, 11, 3),
                    Picture = System.IO.File.ReadAllBytes("Pictures/picture3.jpg"),
                    AvailableBookTypes = new List<BookType>{ BookType.Audiobook}
                },
                new Book
                {
                    Name = "Knyga4",
                    PublishingDate = new DateOnly(2006, 11, 3),
                    Picture = System.IO.File.ReadAllBytes("Pictures/picture4.jpg"),
                    AvailableBookTypes = new List<BookType>{ BookType.Book, BookType.Audiobook}
                },
                new Book
                {
                    Name = "Knyga5",
                    PublishingDate = new DateOnly(2000, 11, 3),
                    Picture = System.IO.File.ReadAllBytes("Pictures/picture5.jpg"),
                    AvailableBookTypes = new List<BookType>{BookType.Audiobook}
                },
                new Book
                {
                    Name = "Knyga6",
                    PublishingDate = new DateOnly(2011, 11, 3),
                    Picture = System.IO.File.ReadAllBytes("Pictures/picture6.jpg"),
                    AvailableBookTypes = new List<BookType>{ BookType.Book, BookType.Audiobook}
                },
            };
            var reservations = new List<Reservation>
            {
                new Reservation(
                    1,
                    BookType.Book,
                    new DateTime(2024,1,2),
                    new DateTime(2024,1,9),
                    true,
                    19.8M),
                new Reservation(
                    1,
                    BookType.Book,
                    new DateTime(2024,1,2),
                    new DateTime(2024,1,9), 
                    true),

            };

            await dataContext.Books.AddRangeAsync(books);
            await dataContext.Reservations.AddRangeAsync(reservations);
            await dataContext.SaveChangesAsync();
            
        }
    }
    
}
