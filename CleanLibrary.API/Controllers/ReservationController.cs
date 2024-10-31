using AutoMapper;
using CleanLibrary.Application.Features.Books.ListBooks;
using CleanLibrary.Application.Features.Reservations;
using CleanLibrary.Application.Features.Reservations.CreateReservation;
using CleanLibrary.Application.Features.Reservations.ListReservations;
using CleanLibrary.Domain.Entities;
using CleanLibrary.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanLibrary.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ReservationController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<List<Reservation>>> ListReservations()
        {
            return await _mediator.Send(new ListReservationsQuery());
        }
        [HttpPost]
        public async Task<Reservation> CreateReservation(ReservationDTO reservation)
        {
            return await _mediator.Send(_mapper.Map<CreateReservationCommand>(reservation));
        }
    }
}
