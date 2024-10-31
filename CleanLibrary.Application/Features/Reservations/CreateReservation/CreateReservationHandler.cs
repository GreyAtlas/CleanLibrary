using CleanLibrary.Application.Interfaces;
using CleanLibrary.Domain.Entities;
using MediatR;
using AutoMapper;

namespace CleanLibrary.Application.Features.Reservations.CreateReservation
{
    public class CreateReservationHandler : IRequestHandler<CreateReservationCommand, Reservation>
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IMapper _mapper;

        public CreateReservationHandler(IReservationRepository reservationRepository, IMapper mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }

        public async Task<Reservation> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            return await _reservationRepository.CreateReservation(_mapper.Map<CreateReservationCommand,Reservation>(request));
        }

    }
}
