using CleanLibrary.Domain.Enums;
using CleanLibrary.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLibrary.Application.Features.Reservations.CreateReservation
{
    public record CreateReservationCommand: IRequest<Reservation>
    {
        public int BookId { get; set; }
        public BookType BookType { get; set; }
        public DateTime ReservationStartDate { get; set; }
        public DateTime ReservationEndDate { get; set; }

        public bool QuickPickup { get; set; }

    }
}
