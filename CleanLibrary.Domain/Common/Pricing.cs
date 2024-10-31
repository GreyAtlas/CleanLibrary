using CleanLibrary.Domain.Enums;

namespace CleanLibrary.Domain.Common
{
    internal static class Pricing
    {
        public const decimal ServiceFee = 3.00M;
        public const decimal QuickPickupFee = 5.00M;

        public static readonly BookTypeFee[] BookTypeFees = new BookTypeFee[2]
        {
            new BookTypeFee(BookType.Book, 2.00M),
            new BookTypeFee(BookType.Audiobook, 3.00M)
        };

        public static readonly Discount[] Discounts = new Discount[2]
        {
            new Discount(3, 0.10M),
            new Discount(10, 0.20M)
        };
    }
}
