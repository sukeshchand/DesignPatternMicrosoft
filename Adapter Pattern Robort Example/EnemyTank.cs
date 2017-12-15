using System;

namespace BridgeTechWhizz
{
    partial class Program
    {
        public class EnemyTank : IEnemyAtacker
        {
            public void fireWeapon()
            {
                Console.WriteLine("Enemy tank fired shots");
            }

            public void driveForward()
            {
                Console.WriteLine("Enemy Tank is moving forward");
            }

            public void assignDriver(string driver)
            {
                Console.WriteLine("Driver {0} is driving the enemy tank ", driver);
            }
        }

    }
}
