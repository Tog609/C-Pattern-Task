public class TankFactory : ICreator
{
    private const string _logMessage = "Tank is creating";

    private const string _exceptionMessage = "Use the overload with parameters.";
    public Transport CreateTransport(int weight, float length, int maxSpeed, float projectileCaliber, int shotsPerMinute, float crewSize)
    {
        Logger.Instance.ShowLog(_logMessage);
        return new Tank(weight, length, maxSpeed, projectileCaliber, shotsPerMinute, crewSize);
    }

    Transport ICreator.CreateTransport()
    {
        throw new NotImplementedException(_exceptionMessage);
    }
}
