using CleanLibrary.Domain;
using CleanLibrary.Domain.Entities;
using CleanLibrary.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
