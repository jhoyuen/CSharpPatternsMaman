namespace ASimpleObserver;

/// <summary>
/// Defines a contract for observer objects in the Observer design pattern.
/// Implementers of this interface are notified of changes or events
/// by the subject they are observing.
/// </summary>
public interface IObserver
{
    /// <summary>
    /// Receives update notifications from the subject.
    /// </summary>
    /// <param name="message">
    /// A string message containing information about the update or event.
    /// </param>
    void Update(string message);
}
