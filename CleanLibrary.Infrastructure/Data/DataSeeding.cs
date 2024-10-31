using CleanLibrary.Domain.Entities;
using CleanLibrary.Domain.Enums;
using System.Xml.Linq;

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
                (
                    1,
                    "Knyga1",
                    new DateOnly(2001,11,3),
                    System.IO.File.ReadAllBytes("Pictures/picture1.jpg"),
                    new List<BookType>{ BookType.Book, BookType.Audiobook}
                ),
                new Book
                (
                    2,
                    "Knyga2",
                    new DateOnly(2001, 11, 3),
                    System.IO.File.ReadAllBytes("Pictures/picture2.jpg"),
                    new List<BookType>{ BookType.Book}


                ),
                new Book
                (
                    3,
                    "Knyga3",
                    new DateOnly(2003, 11, 3),
                    System.IO.File.ReadAllBytes("Pictures/picture3.jpg"),
                    new List<BookType>{ BookType.Audiobook}
                ),
                new Book
                (
                    4,
                    "Knyga4",
                    new DateOnly(2006, 11, 3),
                    System.IO.File.ReadAllBytes("Pictures/picture4.jpg"),
                    new List<BookType>{ BookType.Book, BookType.Audiobook}
                ),
                new Book
                (
                    5,
                    "Knyga5",
                    new DateOnly(2000, 11, 3),
                    System.IO.File.ReadAllBytes("Pictures/picture5.jpg"),
                    new List<BookType>{BookType.Audiobook}
                ),
                new Book
                (
                    6,
                    "Knyga6",
                    new DateOnly(2011, 11, 3),
                    System.IO.File.ReadAllBytes("Pictures/picture6.jpg"),
                    new List<BookType>{ BookType.Book, BookType.Audiobook}
                )
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
