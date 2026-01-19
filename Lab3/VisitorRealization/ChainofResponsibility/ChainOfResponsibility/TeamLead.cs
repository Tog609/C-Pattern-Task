public class TeamLead : IHandler
{
    private IHandler _next;

    private const string _approvedByLeadMessage = "Approved by Team Lead";

    private const byte _numberConstraint = 20;
    public TeamLead(IHandler next)
    {
        _next = next;
    }

    public void Handle(string message)
    {
        if (message.Length < _numberConstraint)
        {
            Console.WriteLine(_approvedByLeadMessage);
        }
        else
        {
            _next?.Handle(message);
        }
    }
}
