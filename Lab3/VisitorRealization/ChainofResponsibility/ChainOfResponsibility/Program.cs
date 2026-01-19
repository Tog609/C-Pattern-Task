public static class Program
{
    public static void Main(string[] args)
    {
        IHandler manager = new Manager();
        IHandler teamLead = new TeamLead(manager);

        teamLead.Handle("Hello,help me");            
        teamLead.Handle("This is a long message"); 

    }
}