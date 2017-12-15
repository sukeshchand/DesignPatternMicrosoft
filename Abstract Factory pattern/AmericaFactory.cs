namespace BridgeTechWhizz
{
    public class AmericaFactory : ContinentFactory //Concrete Factory
    {
        public override Victim CreateVictim() //Factory Method
        {
            return new Deer();
        }
        public override Hunter CreateHunter() //Factory Method
        {
            return new Wolf();
        }
    }
}