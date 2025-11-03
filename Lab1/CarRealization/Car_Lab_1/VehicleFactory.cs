public class VehicleFactory : ICreator
{
    private const string _logMessage = "Vehicle is creating";
    public Transport CreateTransport()
    {
        Logger.Instance.ShowLog( _logMessage);
        return new Vehicle();
    }
}