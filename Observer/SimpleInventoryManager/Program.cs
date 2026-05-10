using SimpleInventoryManager;
using SimpleInventoryManager.Observatory;


var productA = new Product("Lenovo laptop", "brand new laptop");
Inventory.Instance.AddProduct(productA);
productA.SetProductStatus(BaseProductStatus.Discontinued);

var productB = new Product("Samsung Galaxy 14", "Samsung Galaxy 14");
Inventory.Instance.AddProduct(productB);
productB.SetCurrentStockLevel(quantitySold: 3);

var productC = new Product("iphone 17", "iphone 17");
Inventory.Instance.AddProduct(productC);
productC.SetCurrentStockLevel(quantitySold: 5);


var productD = new Product("google pixel", "Google Pixel 8");
Inventory.Instance.AddProduct(productD);

Console.WriteLine("------------------------------");

int quantity;
do
{
    Console.Write("Enter quantity for Google Pixel 8 (enter a positive integer, 0 to exit): ");
    var input = Console.ReadLine();
    if (!int.TryParse(input, out quantity) || quantity < 0)
    {
        Console.WriteLine("Invalid input. Please enter a non-negative integer.");
        continue;
    }
    if (quantity == 0)
        break;

    productD.SetCurrentStockLevel(quantitySold: quantity);
} while (true);

Inventory.Instance.RemoveProduct(productA);
Inventory.Instance.RemoveProduct(productB);
Inventory.Instance.RemoveProduct(productC);
Inventory.Instance.RemoveProduct(productD);

Console.Read();