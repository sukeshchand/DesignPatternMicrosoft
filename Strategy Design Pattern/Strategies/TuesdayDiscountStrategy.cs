namespace BridgeTechWhizz
{
    public class TuesdayDiscountStrategy : IDiscountStrategy
    {
        public double GetDiscountedBill(double billAmount)
        {
            return billAmount - (billAmount * 12 / 100);
        }
    }
}
