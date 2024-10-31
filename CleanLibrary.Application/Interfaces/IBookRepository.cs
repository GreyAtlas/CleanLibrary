using CleanLibrary.Application.Features.Books;
using CleanLibrary.Domain.Entities;
using CleanLibrary.Domain.Enums;

namespace CleanLibrary.Application.Interfaces
{
    public interface IBookRepository 
    {
        public Task<List<Book>> ListBooks(BookSearchTermsDTO bookSearchTerms);



    }
}
