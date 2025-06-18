namespace BatchOrderProcessing;

/// <summary>
/// Concrete Processor implementation
/// </summary>
public class DefaultOrderProcessor : IOrderProcessor
{
    public async Task ProcessAsync(Order order, CancellationToken cancellationToken)
    {
        await Task.Delay(100, cancellationToken);
        Console.WriteLine($"Processed order {order.Id}");
    }
}
