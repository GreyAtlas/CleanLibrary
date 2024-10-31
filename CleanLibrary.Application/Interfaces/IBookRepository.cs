using CleanLibrary.Domain.Entities;
using CleanLibrary.Domain.Enums;

namespace CleanLibrary.Application.Interfaces
{
    public interface IBookRepository 
    {
        public Task<List<Book>> ListBooks(string? name, int? year, List<BookType>? bookTypes);



    }
}
