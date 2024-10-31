using CleanLibrary.Domain.Entities;
using MediatR;

namespace CleanLibrary.Application.Features.Reservations.ListReservations
{
    public record ListReservationsQuery : IRequest<List<Reservation>>;
}
