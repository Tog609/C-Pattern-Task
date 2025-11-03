public class TankFactory : ICreator
{
    private const string _logMessage = "Tank is creating";
    public Transport CreateTransport()
    {
        Logger.Instance.ShowLog( _logMessage);
        return new Tank();
    }
}