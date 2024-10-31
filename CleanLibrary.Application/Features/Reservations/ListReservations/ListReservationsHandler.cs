using AutoMapper;
using CleanLibrary.Application.Features.Books.ListBooks;
using CleanLibrary.Application.Interfaces;
using CleanLibrary.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLibrary.Application.Features.Reservations.ListReservations
{
    public class ListReservationsHandler : IRequestHandler<ListReservationsQuery, List<Reservation>>
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IMapper _mapper;

        public ListReservationsHandler(IReservationRepository reservationRepository, IMapper mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }

        public async Task<List<Reservation>> Handle(ListReservationsQuery request, CancellationToken cancellationToken)
        {
            var results = await _reservationRepository.ListReservations();
            return results;
        }

    }

}
