namespace BridgeTechWhizz
{
    partial class Program
    {
        /// <summary>
        /// Adapter Class
        /// </summary>
        public class EnemyRobotAttackerAdapter : IEnemyAtacker
        {
            private EnemyRobot theRobot;

            public EnemyRobotAttackerAdapter(EnemyRobot newRobot)
            {
                theRobot = newRobot;
            }

            public void fireWeapon()
            {
                theRobot.smashWithHands();
            }

            public void driveForward()
            {
                theRobot.walkForward();
            }

            public void assignDriver(string driver)
            {
                theRobot.reactToHuman(driver);
            }
        }

    }
}
