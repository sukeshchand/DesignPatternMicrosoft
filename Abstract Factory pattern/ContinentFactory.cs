namespace BridgeTechWhizz
{
   
    public abstract class ContinentFactory //Abstract factory
    {
        public abstract Victim CreateVictim();
        public abstract Hunter CreateHunter();
    }
}