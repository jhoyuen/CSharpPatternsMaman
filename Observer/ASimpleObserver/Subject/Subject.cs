namespace ASimpleObserver;

/// <summary>
/// Represents the subject in the Observer design pattern.
/// Maintains a list of observers and notifies them of changes or events.
/// </summary>
public class Subject : ISubject
{
    /// <summary>
    /// The list of observers subscribed to this subject.
    /// </summary>
    private readonly List<IObserver> _observers = new();

    /// <summary>
    /// Attaches an observer to the subject.
    /// </summary>
    /// <param name="observer">The observer to attach.</param>
    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    /// <summary>
    /// Detaches an observer from the subject.
    /// </summary>
    /// <param name="observer">The observer to detach.</param>
    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    /// <summary>
    /// Notifies all attached observers with a message.
    /// </summary>
    /// <param name="message">The message to send to observers.</param>
    public void Notify(string message)
    {
        foreach (var observer in _observers)
        {
            observer.Update(message);
        }
    }
}
