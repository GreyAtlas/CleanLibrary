using CleanLibrary.Domain.Common;
using CleanLibrary.Domain.Enums;

namespace CleanLibrary.Domain.Entities
{
    public class Reservation
    {
        
        public int Id { get; set; }
        public int BookId { get; set; }
        public BookType BookType { get; set; }
        public DateTime ReservationStartDate { get; set; }
        public DateTime ReservationEndDate { get; set; }

        public bool QuickPickup { get; set; }

        public decimal ReservationPrice { get; private set; }

        public Reservation(int bookId, BookType bookType, DateTime reservationStartDate, DateTime reservationEndDate, bool quickPickup)
        {
            BookId = bookId;
            BookType = bookType;
            ReservationStartDate = reservationStartDate;
            ReservationEndDate = reservationEndDate;
            QuickPickup = quickPickup;
            CalculatePrice();
        }

        public Reservation(int bookId, BookType bookType, DateTime reservationStartDate, DateTime reservationEndDate, bool quickPickup, decimal reservationPrice)
        {
            BookId = bookId;
            BookType = bookType;
            ReservationStartDate = reservationStartDate;
            ReservationEndDate = reservationEndDate;
            QuickPickup = quickPickup;
            ReservationPrice = reservationPrice;
        }

        public void CalculatePrice()
        {

            ReservationPrice = 0;
            ReservationPrice += Pricing.ServiceFee;

            if(QuickPickup)
            {
                ReservationPrice += Pricing.QuickPickupFee;
            }

            var duration = (ReservationEndDate - ReservationStartDate).Days;



            foreach (var item in Pricing.BookTypeFees)
            {
                if(item.BookType == BookType)
                {
                    ReservationPrice += item.RentFee * duration;
                    break;
                }
            }

            Discount appliedDiscount = new Discount(0, 0M);
            foreach (var item in Pricing.Discounts)
            {
                if(duration > item.RentDurationThreshold)
                {
                    appliedDiscount = item;
                }
            }

            ReservationPrice -= ReservationPrice * appliedDiscount.DiscountPercentage;
        }
    }
}
