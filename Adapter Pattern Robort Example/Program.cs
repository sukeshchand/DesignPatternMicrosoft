using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeTechWhizz
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // now the attacker is EnemyTank
            EnemyTank enemyTank=new EnemyTank();

            Console.WriteLine("Enemy tank in Basic action\n--------------------------------------");
            enemyTank.assignDriver("Tom");
            enemyTank.driveForward();
            enemyTank.fireWeapon();

            // Enemy Robot basic functionality
            EnemyRobot enemyRobot = new EnemyRobot();
            Console.WriteLine("\n\nEnemy robot in Basic action\n--------------------------------------");
            enemyRobot.reactToHuman("Tom");
            enemyRobot.walkForward();
            enemyRobot.smashWithHands();

            // Use adapter to change the functionality Enemy Robot
            EnemyRobotAttackerAdapter enemyRobotAttackerAdapter = new EnemyRobotAttackerAdapter(enemyRobot);
            Console.WriteLine("\n\nEnemy robot in action\n--------------------------------------");
            enemyRobotAttackerAdapter.assignDriver("Tom");
            enemyRobotAttackerAdapter.driveForward();
            enemyRobotAttackerAdapter.fireWeapon();
            
 

            Console.ReadKey();
        }

    }
}
