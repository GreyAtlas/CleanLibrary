
namespace CleanLibrary.Domain.Common
{
    internal class Discount
    {
        public readonly int RentDurationThreshold;
        public readonly decimal DiscountPercentage;

        public Discount(int rentDurationThreshold, decimal discountPercentage)
        {
            RentDurationThreshold = rentDurationThreshold;
            DiscountPercentage = discountPercentage;
        }
    }
}
