using System;

namespace BridgeTechWhizz
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Singleton Design Pattern.
    /// </summary>
    class MainApp
    {
       
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Enter some text to log. Enter empty string to Quit");
            Console.WriteLine("---------------------------------------------------");
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                Logger.Instance.LogEntry(input); //singleton instance
            }
        }
    }
}
