public class CargoFactory :ICreator
{
    public Transport CreateTransport()
    {
        return new Cargo();
    }
}