namespace SimpleInventoryManager.Observatory;

public interface IProductObserved
{
    void Attach(IProductObserver observer);
    void Detach(IProductObserver observer);
    void Notify();
}
