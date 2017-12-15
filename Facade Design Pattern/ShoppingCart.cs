using System.Collections.Generic;

namespace Workshop
{
    partial class Program
    {
        public class ShoppingCart
        {
            public static List<Cart> ShoppingCartItems { get; set; }

            public void AddProductToShoppingCart(int productId, double rate, int qty)
            {
                if (ShoppingCartItems == null) ShoppingCartItems = new List<Cart>();
                ShoppingCartItems.Add(new Cart() {ProductId = productId, ProductRate = rate, ProductAmount = rate * qty});
            }
        }
    }
}