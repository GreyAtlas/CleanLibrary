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
        public string? Name { get; set; }
        public int? Year { get; set; }
        public List<BookType>? BookTypes { get; set; }

        public ListBooksQuery(string? name, int? year, List<BookType>? bookTypes)
        {
            Name = name;
            Year = year;
            BookTypes = bookTypes;
        }
    }
}
