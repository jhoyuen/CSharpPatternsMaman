using StockPriceTrackerEventBased.SubjectObservable;

namespace StockPriceTrackerEventBased.Observer;

public class AlertSystem
{
    public void Subscribe(StockTicker ticker)
    {
        ticker.PriceChanged += OnPriceChanged;
    }

    private void OnPriceChanged(object? sender, StockPriceChangedEventArgs e)
    {
        if (e.NewPrice > 100)
            Console.WriteLine("[Alert] Stock price exceeded $100!");

        if(e.NewPrice < 50)
            Console.WriteLine("[Alert] Stock price dropped below $50!");
    }
}
