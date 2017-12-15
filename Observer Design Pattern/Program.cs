using System;
using System.Security.Cryptography;

namespace BridgeTechWhizz
{
    partial class MainApp
    {
        static void Main()
        {
            ProductNotifier productNotifier = new ProductNotifier();

            ProductObserver productObserver = new ProductObserver("sukesh@gmail.com");
            productNotifier.Subscribe(productObserver);

            productNotifier.Subscribe(new ProductObserver("neethu@gmail.com"));
            productNotifier.Subscribe(new ProductObserver("saji@gmail.com"));
            Console.ReadKey();

            Console.WriteLine("\n\n");

            productNotifier.ProductCount++; //increase product count - then all the subscribed members will get notification
            Console.ReadKey();
            Console.WriteLine("\n\n");
            productNotifier.Unsubscribe(productObserver);
            Console.ReadKey();
            Console.WriteLine("\n\n");
            productNotifier.ProductCount++; //increase product count - then all the subscribed members will get notification
            Console.ReadKey();
        }
    }
}

