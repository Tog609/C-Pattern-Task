public class Manager : IHandler
{
    public void Handle(string message)
    {
        Console.WriteLine(message);
    }
}