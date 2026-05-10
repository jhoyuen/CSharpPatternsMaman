namespace SimpleInventoryManager
{
    public class BaseProduct
    {
        public int CurrentStockAvailable { get; set; } = 5;
        public BaseProductStatus ProductStatus { get; set; } = BaseProductStatus.Available;
    }
}
