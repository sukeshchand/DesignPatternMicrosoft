using System;

namespace BridgeTechWhizz
{
    class MainApp
    {
   static void Main()
        {
            
            Approver director = new Director();
            Approver vicePresident = new VicePresident();
            Approver president = new President();

            director.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);

            // Generate and process purchase requests
            Purchase p = new Purchase(2034, 350.00, "Office Chair");
            director.ProcessRequest(p);

            p = new Purchase(2036, 21000, "Purchase Printer");
            director.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Purchase Server");
            director.ProcessRequest(p);

            p = new Purchase(2037, 122100.00, "Purchase new office space");
            director.ProcessRequest(p);

            // Wait for user
            Console.ReadKey();
        }
    }
}