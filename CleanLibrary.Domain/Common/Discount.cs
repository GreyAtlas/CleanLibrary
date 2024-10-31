using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
