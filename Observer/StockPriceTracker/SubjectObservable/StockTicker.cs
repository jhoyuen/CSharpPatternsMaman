using StockPriceTracker.Observer;

namespace StockPriceTracker.SubjectObservable;

public class StockTicker
{
    private readonly List<IStockObserver> _observers = new();
    private decimal _price;

    public void Subscribe(IStockObserver observer)
    {
        if (observer == null) throw new ArgumentNullException(nameof(observer));
        _observers.Add(observer);
    }

    public void Unsubscribe(IStockObserver observer)
    {
        if (observer == null) throw new ArgumentNullException(nameof(observer));
        _observers.Remove(observer);
    }

    public void SetPrice(decimal price)
    {
        if (price < 0) throw new ArgumentOutOfRangeException(nameof(price), "Price cannot be negative.");
        _price = price;
        Notify();
    }

    private void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_price);
        }
    }
}
