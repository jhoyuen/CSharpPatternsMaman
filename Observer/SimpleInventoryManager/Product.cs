using SimpleInventoryManager.Observatory;

namespace SimpleInventoryManager;

public class Product : BaseProduct, IProductObserved
{
    private readonly List<IProductObserver> _productObservers = new();

    public Product(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }

    public void Attach(IProductObserver observer)
    {
        _productObservers.Add(observer);
    }

    public void Detach(IProductObserver observer)
    {
        _productObservers.Remove(observer);
    }

    public void SetProductStatus(BaseProductStatus status)
    {
        ProductStatus = status;
        Notify();
    }

    public void SetCurrentStockLevel(int quantitySold)
    {
        CurrentStockAvailable = CurrentStockAvailable - quantitySold;

        if (CurrentStockAvailable <= 0)
        {
            CurrentStockAvailable = 0;
            ProductStatus = BaseProductStatus.OutOfStock;
        }

        Notify();
    }

    public void Notify()
    {
        foreach (var observer in _productObservers)
        {
            observer.Update(this);
        }
    }
}
