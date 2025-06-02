namespace Timer;

public class TimeElapsedEventArgs : EventArgs
{
    public DateTime Time { get; }

    public TimeElapsedEventArgs(DateTime time)
    {
        Time = time;
    }
}
