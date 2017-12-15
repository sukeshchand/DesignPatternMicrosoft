namespace BridgeTechWhizz
{
    public class ThursdayDiscountStrategy : IDiscountStrategy
    {
        public double GetDiscountedBill(double billAmount)
        {
            return billAmount - (billAmount * 13 / 100);
        }
    }
}
