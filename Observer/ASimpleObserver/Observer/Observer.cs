namespace ASimpleObserver;

/// <summary>
/// Represents a concrete implementation of the <see cref="IObserver"/> interface.
/// Receives update notifications from a subject and processes them by displaying a message.
/// </summary>
public class ConcreteObserver : IObserver
{
    private readonly string _name;

    /// <summary>
    /// Initializes a new instance of the <see cref="ConcreteObserver"/> class with a specified name.
    /// </summary>
    /// <param name="name">The name used to identify the observer.</param>
    public ConcreteObserver(string name)
    {
        _name = name;
    }

    /// <summary>
    /// Receives an update message from the subject and writes it to the console.
    /// </summary>
    /// <param name="message">The message sent by the subject.</param>
    public void Update(string message)
    {
        Console.WriteLine($"{_name} received: {message}");
    }
}
