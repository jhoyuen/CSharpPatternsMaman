namespace SimpleInventoryManager.Observatory;

public class ProductDiscontinuedObserver : IProductObserver
{
    public void Update(Product product)
    {
        if(product.ProductStatus == BaseProductStatus.Discontinued)
        {
            Console.WriteLine($"[{product.Name}] is discontinued. Please remove it from the inventory.");
        }
    }
}
