using System;

namespace BridgeTechWhizz
{
    public class MainApp
    {
    
        public static void Main()
        {
            // Create and run the African animal world
            Console.WriteLine("Animal World\n\n");
            Console.WriteLine("Food Chain - Africa");
            Console.WriteLine("----------------------------------------");

            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            Console.WriteLine("\n\n\n\n");

            Console.WriteLine("Food Chain - America");
            Console.WriteLine("----------------------------------------");

            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            // Wait for user input
            Console.ReadKey();
        }
    }
}

