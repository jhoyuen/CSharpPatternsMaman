namespace StockPriceTracker.Observer;

public interface IStockObserver
{
    void Update(decimal price);
}
