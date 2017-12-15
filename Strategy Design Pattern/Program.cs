using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Xml;

namespace BridgeTechWhizz
{
    public class MainApp
    {
        static void Main()
        {
            MovieTicketShopping movieTicketShopping = new MovieTicketShopping(new NoDiscountStrategy());
            Console.WriteLine("Ticket booked by on Sunday, Bill Amount is : " + movieTicketShopping.GetFinalBillAmount());
            Console.WriteLine("\n\n\n");

            movieTicketShopping = new MovieTicketShopping(new MondayDiscountStrategy());
            Console.WriteLine("Ticket booked on Monday" + movieTicketShopping.CustomerName + ", Bill Amount is : " + movieTicketShopping.GetFinalBillAmount());
            Console.WriteLine("\n\n\n");

            movieTicketShopping = new MovieTicketShopping(new TuesdayDiscountStrategy());
            Console.WriteLine("Ticket booked on Tuesday" + movieTicketShopping.CustomerName + ", Bill Amount is : " + movieTicketShopping.GetFinalBillAmount());
            Console.WriteLine("\n\n\n");

            movieTicketShopping = new MovieTicketShopping(new WednesdayDiscountStrategy());
            Console.WriteLine("Ticket booked on Wednesday" + movieTicketShopping.CustomerName + ", Bill Amount is : " + movieTicketShopping.GetFinalBillAmount());
            Console.WriteLine("\n\n\n");

            movieTicketShopping = new MovieTicketShopping(new ThursdayDiscountStrategy());
            Console.WriteLine("Ticket booked on Thursday" + movieTicketShopping.CustomerName + ", Bill Amount is : " + movieTicketShopping.GetFinalBillAmount());
            Console.WriteLine("\n\n\n");

            Console.ReadKey();
        }
   }
}
