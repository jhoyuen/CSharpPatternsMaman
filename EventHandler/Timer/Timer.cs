namespace Timer;

public class Timer
{
    public event EventHandler<TimeElapsedEventArgs>? TimeElapsed;

    public void Start(int milliseconds)
    {
        Console.WriteLine("Timer started.");
        Console.WriteLine($"It is currently {DateTime.Now}");
        System.Threading.Thread.Sleep(milliseconds);

        OnTimeElapsed(new TimeElapsedEventArgs(DateTime.Now));
    }

    protected virtual void OnTimeElapsed(TimeElapsedEventArgs e)
    {
        TimeElapsed?.Invoke(this, e);
    }
}
