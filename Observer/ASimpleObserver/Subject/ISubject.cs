namespace ASimpleObserver;

/// <summary>
/// Defines the contract for a subject in the Observer design pattern.
/// A subject maintains a list of observers and notifies them of changes or events.
/// </summary>
public interface ISubject
{
    /// <summary>
    /// Attaches an observer to the subject.
    /// </summary>
    /// <param name="observer">The observer to attach.</param>
    void Attach(IObserver observer);

    /// <summary>
    /// Detaches an observer from the subject.
    /// </summary>
    /// <param name="observer">The observer to detach.</param>
    void Detach(IObserver observer);

    /// <summary>
    /// Notifies all attached observers with a specific message.
    /// </summary>
    /// <param name="message">The message to send to observers.</param>
    void Notify(string message);
}
