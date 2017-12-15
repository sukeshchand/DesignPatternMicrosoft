namespace BridgeTechWhizz
{
    public class AfricaFactory : ContinentFactory //Concrete Factory
    {
        
        public override Victim CreateVictim() //Factory Method
        {
            return new Rabbit();
        }
        
        public override Hunter CreateHunter() //Factory Method
        {
            return new Lion();
        }
    }
}

