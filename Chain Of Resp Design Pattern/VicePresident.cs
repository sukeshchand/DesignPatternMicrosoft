using System;

namespace BridgeTechWhizz
{
    public class VicePresident : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 25000.0)
            {
                
                Console.WriteLine("{0} approved request# {1} - {3}, Purchase Amount: {2} - Purchase Amount between 10000 and 25000.\n\n",
                   this.GetType().Name, purchase.Number, purchase.Amount, purchase.Purpose);

            }
            else if (successor != null)
            {
                successor.ProcessRequest(purchase);
            }
        }
    }
}