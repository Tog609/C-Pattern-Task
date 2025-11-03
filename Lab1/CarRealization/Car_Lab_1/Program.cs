class Program
{
    static void Main(string[] args)
    {
        ICreator creator = new CargoFactory();
        creator.CreateTransport();
        ICreator creator1 = new TankFactory();
        creator1.CreateTransport();
        ICreator creator2 = new VehicleFactory();
        creator2.CreateTransport();
    }
}