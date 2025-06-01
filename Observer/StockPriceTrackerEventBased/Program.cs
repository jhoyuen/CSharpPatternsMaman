using StockPriceTrackerEventBased.Observer;
using StockPriceTrackerEventBased.SubjectObservable;

var stockTicker = new StockTicker();

var display = new PriceDisplay();
var alert = new AlertSystem();

display.Subscribe(stockTicker);
alert.Subscribe(stockTicker);

stockTicker.SetPrice(95.00m);
stockTicker.SetPrice(105.00m);
stockTicker.SetPrice(15.00m);