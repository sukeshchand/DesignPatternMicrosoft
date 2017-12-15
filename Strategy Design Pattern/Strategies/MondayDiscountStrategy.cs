namespace BridgeTechWhizz
{
    public class MondayDiscountStrategy : IDiscountStrategy
    {
        public double GetDiscountedBill(double billAmount)
        {
            return billAmount - (billAmount * 10 / 100);
        }
    }
}
