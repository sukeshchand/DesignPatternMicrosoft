using System;

namespace BridgeTechWhizz
{

    public class ProductObserver : IProductObserver
    {
        public string ObserverName { get; private set; }
        public ProductObserver(string observerName)
        {
            ObserverName = observerName;
        }
        public void Update(int itemsCount)
        {
            Console.WriteLine("Notifying to " + ObserverName + " - Message: The new product has arrived at the store. Total Items in the Store: " + itemsCount);
        }
    }
}


