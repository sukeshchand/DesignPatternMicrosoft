using System;

namespace BridgeTechWhizz
{
    public class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
            {
                Console.WriteLine("{0} approved request# {1} - {3}, Purchase Amount: {2} - Purchase 25000 and 100000.\n\n",
                    this.GetType().Name, purchase.Number, purchase.Amount, purchase.Purpose);
            }
            else
            {
                Console.WriteLine("{0} Not approved request# {1} - Purchase Amount: {2} - {3} - Requires an executive meeting! - Reason for not approval Amount > 100000\n\n",
                    this.GetType().Name, purchase.Number, purchase.Amount, purchase.Purpose);
            }
        }
    }
}