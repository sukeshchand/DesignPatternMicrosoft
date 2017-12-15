using System;

namespace Workshop
{
    partial class Program
    {
        public class InvoiceManager
        {
            public void PrintInvoice(Invoice invoice)
            {
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Invoice");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                foreach (var cart in invoice.ShoppingCart)
                {
                    Console.WriteLine("ProductId: " + cart.ProductId + ", Product Rate:" + cart.ProductRate + ", Product Amount:" + cart.ProductAmount);
                }
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Total Amount: " + invoice.TotalAmount);
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

            }
        }
    }
}