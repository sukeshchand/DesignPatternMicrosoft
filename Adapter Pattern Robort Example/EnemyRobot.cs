using System;

namespace BridgeTechWhizz
{
    partial class Program
    {
        /// <summary>
        /// Adaptee Class
        /// </summary>
        public class EnemyRobot
        {
            public void smashWithHands()
            {
                Console.WriteLine("Enemy robot is causing damage with its hands");
            }

            public void walkForward()
            {
                Console.WriteLine("Enemy robot walks forward");
            }

            public void reactToHuman(string driver)
            {
                Console.WriteLine("Enemy robot tramps on {0}", driver);
            }
        }

    }
}
