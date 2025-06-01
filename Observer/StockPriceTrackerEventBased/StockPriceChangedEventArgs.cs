namespace StockPriceTrackerEventBased;

public class StockPriceChangedEventArgs
{
    public decimal NewPrice { get; }

    public StockPriceChangedEventArgs(decimal newPrice)
    {
        NewPrice = newPrice;
    }
}
