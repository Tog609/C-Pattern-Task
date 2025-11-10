using System.Drawing;

public class VehicleFactory : ICreator
{
    private const string _logMessage = "Vehicle is creating";
    private const string _exceptionMessage = "Use the overload with parameters.";

    public Transport CreateTransport(int weight, float length, int maxSpeed, Color color, int driveType, int classType)
    {
        Logger.Instance.ShowLog(_logMessage);
        return new Vehicle(weight, length, maxSpeed, color, driveType, classType);
    }

    Transport ICreator.CreateTransport()
    {
        throw new NotImplementedException(_exceptionMessage);
    }
}
