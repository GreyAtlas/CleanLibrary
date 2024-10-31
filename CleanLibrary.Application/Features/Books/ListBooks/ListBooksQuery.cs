using CleanLibrary.Domain.Entities;
using MediatR;


namespace CleanLibrary.Application.Features.Books.ListBooks
{
    public record ListBooksQuery : IRequest<List<Book>>
    {
        public BookSearchTermsDTO SearchTerms { get; set; }
        
        public ListBooksQuery(BookSearchTermsDTO searchTerms)
        {
            SearchTerms = searchTerms;
        }
    }
}
