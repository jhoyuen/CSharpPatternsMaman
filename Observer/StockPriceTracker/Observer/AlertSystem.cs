namespace StockPriceTracker.Observer;

public class AlertSystem : IStockObserver
{
    private decimal _price;
    public void Update(decimal price)
    {
        _price = price;
        if(_price > 100)
        {
            SendExceededAlert();
        }
        if (_price < 50)
        {
            SendBelowThresholdAlert();
        }
    }
    private void SendExceededAlert()
    {
        Console.WriteLine("[Alert] Stock price exceeded $100!");
    }

    private void SendBelowThresholdAlert()
    {
        Console.WriteLine("[Alert] Stock price is below $50!");
    }
}
