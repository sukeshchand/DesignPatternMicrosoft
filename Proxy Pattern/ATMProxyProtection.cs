using System;

namespace Proxy_Pattern
{
    public class ATMProxyProtection : IGetATMData
    {
        public int GetATMCash()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                ATMMachine atmMachine = new ATMMachine();
                return atmMachine.GetATMCash();
            }
            else
            {
                throw new Exception("You can access ATM Cash service only on Monday.");
            }
        }

        public int GetATMStatus()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                ATMMachine atmMachine = new ATMMachine();
                return atmMachine.GetATMStatus();
            }
            else
            {
                throw new Exception("You can access ATM Status service only on Monday.");
            }
        }
    }
}