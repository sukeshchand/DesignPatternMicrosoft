using System;

namespace BridgeTechWhizz
{
    public class Lion : Hunter //Product class
    {
        public override void Eat(Victim h)
        {
            // Eat Rabbit
            Console.WriteLine(this.GetType().Name +
                              " eats " + h.GetType().Name);
        }
    }
}