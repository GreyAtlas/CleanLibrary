using CleanLibrary.Domain.Entities;

namespace CleanLibrary.Application.Interfaces
{
    public interface IReservationRepository
    {
        public Task<List<Reservation>> ListReservations();

        public Task<Reservation> CreateReservation(Reservation reservation);

    }
}
