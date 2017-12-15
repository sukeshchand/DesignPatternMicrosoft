namespace BridgeTechWhizz
{
    public class WednesdayDiscountStrategy : IDiscountStrategy
    {
        public double GetDiscountedBill(double billAmount)
        {
            return billAmount - (billAmount * 20 / 100);
        }
    }
}
