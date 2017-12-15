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
            movieTicketShopping.BillAmount = 250;
            while (true)
            {
                Console.WriteLine("Base Ticket Rate is : 250, Enter day to know the discount: ");
                string input = Console.ReadLine();
                if (input == "") break;
                switch (input.ToLower())
                {
                    case "sunday":
                        movieTicketShopping.CustomerName = "Sunday Customer";
                        movieTicketShopping.CurrentDiscountStrategy = new NoDiscountStrategy();
                        break;
                    case "monday":
                        movieTicketShopping.CustomerName = "Monday Customer";
                        movieTicketShopping.CurrentDiscountStrategy = new MondayDiscountStrategy();
                        break;
                    case "tuesday":
                        movieTicketShopping.CustomerName = "Tuesday Customer";
                        movieTicketShopping.CurrentDiscountStrategy = new TuesdayDiscountStrategy();
                        break;
                    case "wednesday":
                        movieTicketShopping.CustomerName = "Wednesday Customer";
                        movieTicketShopping.CurrentDiscountStrategy = new WednesdayDiscountStrategy();
                        break;
                    case "thursday":
                        movieTicketShopping.CustomerName = "Thursday Customer";
                        movieTicketShopping.CurrentDiscountStrategy = new ThursdayDiscountStrategy();
                        break;
                    case "friday":
                        movieTicketShopping.CustomerName = "Friday Customer";
                        movieTicketShopping.CurrentDiscountStrategy = new FridayDiscountStrategy();
                        break;
                    case "saturday":
                        movieTicketShopping.CustomerName = "Saturday Customer";
                        movieTicketShopping.CurrentDiscountStrategy = new SaturdayDiscountStrategy();
                        break;
                    default:
                        movieTicketShopping.CustomerName = "";
                        Console.WriteLine("Invalid Day");
                        break;
                }
                if (movieTicketShopping.CustomerName != "")
                {
                    Console.WriteLine("Ticket booked by " + movieTicketShopping.CustomerName + ", Bill Amount is : " + movieTicketShopping.GetFinalBillAmount());
                    Console.WriteLine("\n\n\n");
                    Console.ReadKey();
                }
            }

        }
   }
}
