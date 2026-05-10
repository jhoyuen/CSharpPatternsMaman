namespace SimpleInventoryManager.Observatory;

public class ProductDangerouslyLowOnStockObserver : IProductObserver
{
    public void Update(Product product)
    {
        if (product.CurrentStockAvailable > 0 && product.CurrentStockAvailable <= 2)
        {
            Console.WriteLine($"[{product.Name}] is dangerously low on stock. Please restock it immediately.");
        }
    }
}
