namespace BridgeTechWhizz
{
    public class SaturdayDiscountStrategy : IDiscountStrategy
    {
        public double GetDiscountedBill(double billAmount)
        {
            return billAmount - (billAmount * 11 / 100);
        }
    }
}
