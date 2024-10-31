using CleanLibrary.Domain.Entities;
using CleanLibrary.Application.Features.Reservations;
using CleanLibrary.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLibrary.Application.Interfaces
{
    public interface IReservationRepository
    {
        public Task<List<Reservation>> ListReservations();

        public Task<Reservation> CreateReservation(Reservation reservation);

    }
}
