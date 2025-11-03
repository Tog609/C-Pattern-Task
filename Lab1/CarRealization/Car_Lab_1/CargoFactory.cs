public class CargoFactory :ICreator
{
    private const string _logMessage = "Cargo is creating";
    public Transport CreateTransport()
    {
        Logger.Instance.ShowLog( _logMessage);
        return new Cargo();
    }
}