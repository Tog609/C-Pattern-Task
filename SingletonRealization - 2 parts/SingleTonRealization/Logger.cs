sealed class Logger
{
    private static Logger _instance = new Logger();

    public static Logger Instance
    {
        get { return _instance; }
    }

    private Logger() { }

    public void SendLogs(string logMessage)
    {
        Console.WriteLine(logMessage);
    }
}