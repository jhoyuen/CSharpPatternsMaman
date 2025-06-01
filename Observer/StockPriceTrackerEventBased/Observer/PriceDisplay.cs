using StockPriceTrackerEventBased.SubjectObservable;

namespace StockPriceTrackerEventBased.Observer;

public class PriceDisplay
{
    public void Subscribe(StockTicker ticker)
    {
        ticker.PriceChanged += OnPriceChanged;
    }

    private void OnPriceChanged(object? sender, StockPriceChangedEventArgs e)
    {
        Console.WriteLine($"[Display] New Stock Price: {e.NewPrice:C}");
    }
}
