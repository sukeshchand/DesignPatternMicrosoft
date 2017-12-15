using System.Collections.Generic;

namespace Workshop
{
    partial class Program
    {
        public class OnlineShoppingFacade
        {
            public void PurchaseOnlineProducts(List<PurchaseItem> purchaseItems)
            {
                PriceList priceList = new PriceList();
                ProductDetails productDetails = new ProductDetails();
                ShoppingCart shoppingCart = new ShoppingCart();
                foreach (var purchaseItem in purchaseItems)
                {
                    var productId = productDetails.GetProductIdByCode(purchaseItem.ItemCode);
                    var productRate = priceList.GetRate(productId);
                    shoppingCart.AddProductToShoppingCart(productId, productRate, purchaseItem.ItemQty);
                }

                Order order = new Order();
                var invoice = order.PlaceOrder(ShoppingCart.ShoppingCartItems);
                InvoiceManager invoiceManager = new InvoiceManager();
                invoiceManager.PrintInvoice(invoice);
            }
        }
    }
}