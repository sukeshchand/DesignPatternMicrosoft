namespace BridgeTechWhizz
{
    public class NoDiscountStrategy : IDiscountStrategy
    {
        public double GetDiscountedBill(double billAmount)
        {
            return billAmount; // No Discount
        }
    }
}
