using CleanLibrary.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLibrary.Application.Features.Reservations.ListReservations
{
    public record ListReservationsQuery : IRequest<List<Reservation>>;
}
