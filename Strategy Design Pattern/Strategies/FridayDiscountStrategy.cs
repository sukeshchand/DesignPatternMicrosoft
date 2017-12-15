namespace BridgeTechWhizz
{
    public class FridayDiscountStrategy : IDiscountStrategy
    {
        public double GetDiscountedBill(double billAmount)
        {
            return billAmount - (billAmount * 4 / 100);
        }
    }
}
