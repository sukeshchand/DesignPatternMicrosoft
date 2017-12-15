using System.Collections.Generic;
using System.Linq;

namespace Workshop
{
    partial class Program
    {
        public class Order
        {
            public Invoice PlaceOrder(List<Cart> shoppingCart)
            {
                double totalAmount = shoppingCart.Sum(cart => cart.ProductAmount);
                return new Invoice() {ShoppingCart = shoppingCart, TotalAmount = totalAmount};
            }
        }
    }
}