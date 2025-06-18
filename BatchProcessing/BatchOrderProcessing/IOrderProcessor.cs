namespace BatchOrderProcessing;

/// <summary>
/// IOrderProcessor Strategy Pattern
/// </summary>
public interface IOrderProcessor
{
    Task ProcessAsync(Order order, CancellationToken cancellationToken);
}
