public class VehicleFactory : ICreator
{
    public Transport CreateTransport()
    {
        return new Vehicle();
    }
}