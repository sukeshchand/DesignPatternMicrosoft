using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Proxy design pattern limits access to just the methods you want made accessible in another class.
            Console.WriteLine("1) Remote Proxy Example - Not exposing all the data/methods of the real object ");
            Console.WriteLine("------------------------");
            IGetATMData atmProxyData1 = new ATMProxyRemote(); // since we are using proxy class, we can only get the atm data. Its looks like actual object
            Console.WriteLine("ATM Cash: " + atmProxyData1.GetATMCash());
            Console.WriteLine("ATM Status: " + atmProxyData1.GetATMStatus());
            Console.ReadKey();

            Console.WriteLine("\n\n1) Virtual Proxy Example - Not uses the real subject(object) because its will be costly");
            Console.WriteLine("------------------------");
            IGetATMData atmProxyData3 = new ATMProxyVirtual();
            Console.WriteLine("ATM Cash: " + atmProxyData3.GetATMCash());
            Console.WriteLine("ATM Status: " + atmProxyData3.GetATMStatus());
            Console.ReadKey();


            Console.WriteLine("\n\n2) Protection Proxy Example - control the client call by applying rules inside the proxy class");
            Console.WriteLine("------------------------");
            IGetATMData atmProxyData2 = new ATMProxyProtection();
            try
            {
                Console.WriteLine("ATM Cash: " + atmProxyData2.GetATMCash());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            try
            {
                Console.WriteLine("ATM Cash: " + atmProxyData2.GetATMStatus());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
