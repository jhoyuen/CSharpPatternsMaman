namespace StockPriceTracker.Observer;

public class PriceDisplay : IStockObserver
{
    private decimal _price;
    public void Update(decimal price)
    {
        _price = price;
        Display();
    }
    private void Display()
    {
        Console.WriteLine($"[Display] New Stock Price: {_price:C}");
    }
}
