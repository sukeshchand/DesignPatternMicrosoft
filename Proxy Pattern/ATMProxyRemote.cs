namespace Proxy_Pattern
{
    public class ATMProxyRemote : IGetATMData
    {
        public int GetATMCash()
        {
            ATMMachine atmMachine = new ATMMachine();
            return atmMachine.GetATMCash();
        }

        public int GetATMStatus()
        {
            ATMMachine atmMachine = new ATMMachine();
            return atmMachine.GetATMStatus();
        }
    }
}