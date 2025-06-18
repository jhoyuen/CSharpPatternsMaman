namespace BatchOrderProcessing;

/// <summary>
/// Slow naive order processor
/// </summary>
public class SlowOrderProcessor
{
    public void ProcessAll(List<Order> orders)
    {
        foreach (var order in orders)
        {
            Process(order);
        }
    }

    private void Process(Order order)
    {
        // Simulate slow operation
        Thread.Sleep(100);
        Console.WriteLine($"Processed order {order.Id}");
    }
}
