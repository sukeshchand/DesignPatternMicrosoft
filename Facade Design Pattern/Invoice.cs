using System.Collections.Generic;

namespace Workshop
{
    partial class Program
    {
        public class Invoice
        {
            public List<Cart> ShoppingCart { get; set; }
            public double TotalAmount { get; set; }
        }
    }
}