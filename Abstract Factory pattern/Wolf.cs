using System;

namespace BridgeTechWhizz
{
    public class Wolf : Hunter //Product class
    {
        public override void Eat(Victim h)
        {
            // Eat Deer
            Console.WriteLine(this.GetType().Name +
                              " eats " + h.GetType().Name);
        }
    }
}