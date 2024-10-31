using CleanLibrary.Domain.Enums;


namespace CleanLibrary.Application.Features.Reservations
{
    public class ReservationDTO
    {
        public required int BookId { get; set; }
        public BookType BookType { get; set; }
        public string ReservationStartDate { get; set; }
        public string ReservationEndDate { get; set; }

        public bool QuickPickup { get; set; }

        public ReservationDTO(int bookId, BookType bookType, string reservationStartDate, string reservationEndDate, bool quickPickup)
        {
            BookId = bookId;
            BookType = bookType;
            ReservationStartDate = reservationStartDate;
            ReservationEndDate = reservationEndDate;
            QuickPickup = quickPickup;
        }
    }
}
