using StockPriceTracker.Observer;
using StockPriceTracker.SubjectObservable;

var stockTicker = new StockTicker();

IStockObserver display = new PriceDisplay();
IStockObserver alert = new AlertSystem();
IStockObserver logger = new Logger();

stockTicker.Subscribe(display);
stockTicker.Subscribe(alert);
stockTicker.Subscribe(logger);

stockTicker.SetPrice(95.00m);
stockTicker.SetPrice(105.00m);
stockTicker.SetPrice(15.00m);