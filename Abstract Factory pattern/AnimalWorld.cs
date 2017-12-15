namespace BridgeTechWhizz
{
    public class AnimalWorld
    {
        private Victim _Victim;
        private Hunter _Hunter;

        // Constructor
        public AnimalWorld(ContinentFactory factory)
        {
            // Here another factory is deciding who is Hunter and who is victim
            _Hunter = factory.CreateHunter();
            _Victim = factory.CreateVictim();
        }

        public void RunFoodChain()
        {
            _Hunter.Eat(_Victim);
        }
    }
}