using CleanLibrary.Application.Features.WeatherForecasts;
using CleanLibrary.Domain.Entities;
using CleanLibrary.Domain.Enums;
using CleanLibrary.Application.Features.Books.ListBooks;
using CleanLibrary.Application.Features.Books;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace CleanLibrary.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly IMediator _mediator;

        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<List<Book>>> ListBooks(string? name, int? year, List<BookType>? bookTypes)
        {
            return await _mediator.Send(new ListBooksQuery(name, year, bookTypes));
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<List<BookDTO>>> GetBook(int id)
        {
            throw new NotImplementedException();
        }
    }

}
