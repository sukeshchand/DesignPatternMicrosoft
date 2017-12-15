using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Workshop
{
    partial class Program
    {
        static void Main(string[] args)
        {
            List<PurchaseItem> purchaseItems = new List<PurchaseItem>();
            // adding 5 items to purchase list
            purchaseItems.Add(new PurchaseItem() { ItemCode = 1, ItemQty = 4 });
            purchaseItems.Add(new PurchaseItem() { ItemCode = 2, ItemQty = 1 });
            purchaseItems.Add(new PurchaseItem() { ItemCode = 3, ItemQty = 2 });
            purchaseItems.Add(new PurchaseItem() { ItemCode = 4, ItemQty = 3 });
            purchaseItems.Add(new PurchaseItem() { ItemCode = 5, ItemQty = 5 });
            purchaseItems.Add(new PurchaseItem() { ItemCode = 6, ItemQty = 3 });
            OnlineShoppingFacade onlineShoppingFacade = new OnlineShoppingFacade();
            onlineShoppingFacade.PurchaseOnlineProducts(purchaseItems);
            Console.ReadKey();

        }
    }
}