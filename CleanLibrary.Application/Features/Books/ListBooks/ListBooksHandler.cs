using CleanLibrary.Application.Interfaces;
using MediatR;
using AutoMapper;
using System.Diagnostics;
using CleanLibrary.Domain.Entities;

namespace CleanLibrary.Application.Features.Books.ListBooks
{
    public class ListBooksHandler : IRequestHandler<ListBooksQuery, List<Book>>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public ListBooksHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<List<Book>> Handle(ListBooksQuery request, CancellationToken cancellationToken)
        {
            var results = await _bookRepository.ListBooks(request.SearchTerms);

            return results;//_mapper.Map<List<Book>, List<BookDTO>>(results);
        }
    }
}
