namespace BridgeTechWhizz
{
    public interface IDiscountStrategy
    {
        double GetDiscountedBill(double billAmount);
    }
}
