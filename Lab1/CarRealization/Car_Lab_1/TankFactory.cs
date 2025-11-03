public class TankFactory : ICreator
{
    public Transport CreateTransport()
    {
        return new Tank();
    }
}