namespace Proxy_Pattern
{
    public class ATMMachine : IGetATMData
    {
        private int _atmCash = 100;
        private int _atmStatus = 1;
        public int GetATMCash()
        {
            return _atmCash;
        }

        public int GetATMStatus()
        {
            return _atmStatus;
        }

        public void SetATMCash(int value)
        {
            _atmCash = value;
        }

        public void SetATMStatus(int status)
        {
            _atmStatus = status;
        }
    }
}
