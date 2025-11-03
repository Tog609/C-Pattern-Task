class Program
{
    static void Main(string[] args)
    {
        ICreator creator = new CargoFactory();
        var cargo = creator.CreateTransport();
        Console.WriteLine(cargo.ToString());
    }
}