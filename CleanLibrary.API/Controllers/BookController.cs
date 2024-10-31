using CleanLibrary.Domain.Entities;
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
        public async Task<ActionResult<List<Book>>> ListBooks([FromBody]BookSearchTermsDTO bookSearchTerms)
        {
            return await _mediator.Send(new ListBooksQuery(bookSearchTerms));
        }

    }

}
