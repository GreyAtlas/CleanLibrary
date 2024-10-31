using CleanLibrary.Application.Interfaces;
using CleanLibrary.Domain.Entities;
using CleanLibrary.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLibrary.Infrastructure.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly LibraryDataContext _context;

        public ReservationRepository(LibraryDataContext context)
        {
            _context = context;
        }
        public async Task<List<Reservation>> ListReservations()
        {
            return await _context.Reservations.ToListAsync();
        }

        public async Task<Reservation> CreateReservation(Reservation reservation)
        {
            var addedValue = await _context.Reservations.AddAsync(reservation);
            await _context.SaveChangesAsync();
            return addedValue.Entity;
        }


    }
}
