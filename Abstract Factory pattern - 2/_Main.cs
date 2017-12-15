using System;

namespace BridgeTechWhizz
{
    public class MainApp
    {
    
        // Client program
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter Connection choice?");
                var input = Console.ReadLine();
                IDatabase database = DatabaseFactory.GetDatabaseObject(input); // Main Factory provides the database object
                database.PrintConnection();
                Console.WriteLine();
            }
        }
    }
}

