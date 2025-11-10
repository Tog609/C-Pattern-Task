public class CargoFactory : ICreator
{
    private const string _logMessage = "Cargo is creating";

    private const string _exceptionMessage = "Use the overload with parameters.";

    public Transport CreateTransport(int weight, float length, int maxSpeed, int tonnage, int tankVolume, int axlesAmount)
    {
        Logger.Instance.ShowLog(_logMessage);
        return new Cargo(weight, length, maxSpeed, tonnage, tankVolume, axlesAmount);
    }

    Transport ICreator.CreateTransport()
    {
        throw new NotImplementedException(_exceptionMessage);
    }
}
