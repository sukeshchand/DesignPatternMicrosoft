namespace Proxy_Pattern
{
    public class ATMProxyVirtual : IGetATMData
    {
        private int cachedATMCash = 5000; // in reality this will be taken from caching service
        private int cachedATMStatus = 2; // in reality this will be taken from caching service
        public int GetATMCash()
        {
            return cachedATMCash;
        }

        public int GetATMStatus()
        {
            return cachedATMStatus;
        }
    }
}