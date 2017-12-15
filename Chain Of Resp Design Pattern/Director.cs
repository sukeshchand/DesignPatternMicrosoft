using System;

namespace BridgeTechWhizz
{
    public class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                Console.WriteLine("{0} approved request# {1} - {3}, Purchase Amount: {2} - Purchase Amount < 100000\n\n",
                    this.GetType().Name, purchase.Number, purchase.Amount, purchase.Purpose);
            }
            else if (successor != null)
            {
                successor.ProcessRequest(purchase);
            }
        }
    }
}