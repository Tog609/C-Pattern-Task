public sealed class Logger
{
    private static readonly Logger _instance = new Logger();

    public static Logger Instance => _instance;
    private Logger() { }

    public void ShowLog(string message)
    {
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] INFO: {message}");
    }
}