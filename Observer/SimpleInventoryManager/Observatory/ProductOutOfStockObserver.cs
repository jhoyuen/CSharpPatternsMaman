namespace SimpleInventoryManager.Observatory;

public class ProductOutOfStockObserver : IProductObserver
{
    public void Update(Product product)
    {
        if(product.ProductStatus == BaseProductStatus.OutOfStock)
        {
            Console.WriteLine($"[{product.Name}] is out of stock. Please restock it as soon as possible.");
        }
    }
}
