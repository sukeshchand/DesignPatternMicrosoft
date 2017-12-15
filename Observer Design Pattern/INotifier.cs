namespace BridgeTechWhizz
{
    public interface INotifier
    {
        void Subscribe(ProductObserver observer);
        void Unsubscribe(ProductObserver observer);
        void NotifyAll(int productCount);
    }
}


