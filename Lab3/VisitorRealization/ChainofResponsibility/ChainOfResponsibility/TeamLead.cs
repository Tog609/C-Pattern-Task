public class TeamLead : IHandler
{
    private IHandler _next;

    public TeamLead(IHandler next)
    {
        _next = next;
    }

    public void Handle(string message)
    {
        if (message.Length < 10)
        {
            Console.WriteLine("Approved by Team Lead");
        }
        else
        {
            _next?.Handle(message);
        }
    }
}
