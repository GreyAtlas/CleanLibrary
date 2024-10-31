using CleanLibrary.Application;
using CleanLibrary.Application.Interfaces;
using CleanLibrary.Domain.Enums;
using CleanLibrary.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using CleanLibrary.Domain.Entities;

namespace CleanLibrary.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDataContext _context;

        public BookRepository(LibraryDataContext context)
        {
            _context = context;
        }
        public async Task<List<Book>> ListBooks(string? name, int? year, List<BookType>? bookTypes)
        {
            var queryable = _context.Books.AsQueryable();
            if (name != null)
            {
                queryable = queryable.Where(x => x.Name == name);
            }
            if (year != null)
            {
                queryable = queryable.Where(x => x.PublishingDate.Year == year);
            }
            if (bookTypes != null)
            {
                if(bookTypes.Count > 0)
                {
                    foreach(var bookType in bookTypes)
                    {
                        queryable = queryable.Where(x => x.AvailableBookTypes.Contains(bookType));
                    }

                }
            }

            return await queryable.ToListAsync();
        }
    }
}
