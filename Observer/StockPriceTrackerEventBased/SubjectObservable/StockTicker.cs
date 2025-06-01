namespace StockPriceTrackerEventBased.SubjectObservable;

public class StockTicker
{
    private decimal _price;

    public event EventHandler<StockPriceChangedEventArgs>? PriceChanged;

    public void SetPrice(decimal newPrice)
    {
        _price = newPrice;
        OnPriceChanged(new StockPriceChangedEventArgs(newPrice));
    }

    protected virtual void OnPriceChanged(StockPriceChangedEventArgs e)
    {
        PriceChanged?.Invoke(this, e);
    }
}
