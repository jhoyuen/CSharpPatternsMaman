namespace StockPriceTracker.Observer;

public class Logger : IStockObserver
{
    private decimal _price;
    public void Update(decimal price)
    {
        _price = price;
        LogPrice();
    }
    private void LogPrice()
    {
        Console.WriteLine($"[Log] Stock price updated to: {_price}");
    }
}
