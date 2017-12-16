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
                if (database == null) break;
                database.PrintConnection();
                Console.WriteLine();
            }
        }
    }
}

