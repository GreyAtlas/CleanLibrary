using CleanLibrary.Application.Interfaces;
using CleanLibrary.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using CleanLibrary.Domain.Entities;
using CleanLibrary.Application.Features.Books;

namespace CleanLibrary.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDataContext _context;

        public BookRepository(LibraryDataContext context)
        {
            _context = context;
        }
        public async Task<List<Book>> ListBooks(BookSearchTermsDTO bookSearchTerms)
        {
            var queryable = _context.Books.AsQueryable();
            if (bookSearchTerms.Name != null && bookSearchTerms.Name != "")
            {
                queryable = queryable.Where(x => x.Name == bookSearchTerms.Name);
            }
            if (bookSearchTerms.PublishingDate != null)
            {
                queryable = queryable.Where(x => x.PublishingDate.Year == bookSearchTerms.PublishingDate);
            }
            if (bookSearchTerms.AvailableBookTypes != null)
            {
                if(bookSearchTerms.AvailableBookTypes.Count > 0)
                {
                    foreach(var bookType in bookSearchTerms.AvailableBookTypes)
                    {
                        queryable = queryable.Where(x => x.AvailableBookTypes.Contains(bookType));
                    }

                }
            }

            return await queryable.ToListAsync();
        }
    }
}
