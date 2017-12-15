using System;
using System.Collections.Generic;

namespace BridgeTechWhizz
{
    public class ProductNotifier : INotifier
    {
        private List<ProductObserver> productObserver = new List<ProductObserver>();
        private int _int;
        public int ProductCount
        {
            get
            {
                return _int;
            }
            set
            {
                Console.WriteLine("Product count changed from " + _int + " to " + value);
                // Just to make sure that if there is an increase in inventory then only we are notifying the observers.
                if (value > _int)
                {
                    NotifyAll(value);
                    _int = value;
                }
            }
        }
        public void Subscribe(ProductObserver observer)
        {
            Console.WriteLine(observer.ObserverName + " Subscribed for notification");
            productObserver.Add(observer);
        }

        public void Unsubscribe(ProductObserver observer)
        {
            Console.WriteLine(observer.ObserverName + " Unsubscribed from notification");
            productObserver.Remove(observer);
        }

        public void NotifyAll(int productCount)
        {
            productObserver.ForEach(x => x.Update(productCount));
        }
    }
}


