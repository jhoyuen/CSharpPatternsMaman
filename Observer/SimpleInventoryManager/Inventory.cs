using SimpleInventoryManager.Observatory;

namespace SimpleInventoryManager;

public class Inventory
{
    private static Inventory? _instance;
    public static Inventory Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Inventory();
            }
            return _instance;
        }
    }

    private ProductOutOfStockObserver _productOutOfStockObserver;
    private ProductDangerouslyLowOnStockObserver _productDangerouslyLowOnStockObserver;
    private ProductDiscontinuedObserver _productDiscontinuedObserver;

    public Inventory()
    {
        Products = new List<Product>();
        _productOutOfStockObserver = new ProductOutOfStockObserver();
        _productDangerouslyLowOnStockObserver = new ProductDangerouslyLowOnStockObserver();
        _productDiscontinuedObserver = new ProductDiscontinuedObserver();
    }
    public List<Product> Products { get; set; }

    public void AddProduct(Product product)
    {
        product.Attach(_productOutOfStockObserver);
        product.Attach(_productDangerouslyLowOnStockObserver);
        product.Attach(_productDiscontinuedObserver);
        Products.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        product.Detach(_productOutOfStockObserver);
        product.Detach(_productDangerouslyLowOnStockObserver);
        product.Detach(_productDiscontinuedObserver);
        Products.Remove(product);
    }

    public void NotifyChangesInAllProducts()
    {
        foreach (var product in Products)
        {
            product.Notify();
        }
    }
    
    public void NotifyChangesInProduct(Product product)
    {
        product.Notify();
    }
}
