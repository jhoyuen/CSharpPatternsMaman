namespace Timer;

public class Alarm
{
    public void Subscribe(Timer timer)
    {
        timer.TimeElapsed += OnTimer_TimeElapsed;
    }

    private void OnTimer_TimeElapsed(object? sender, TimeElapsedEventArgs e)
    {
        Console.WriteLine($"Alarm triggered at: {e.Time}");
    }
}
