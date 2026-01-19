public class Program
{
    public static void Main()
    {
        var container = new Container();

        var tesla = new Tesla("Tesla", 123);
        var bmv = new BMW("BMW", 131);

        container.Add(tesla);
        container.Add(bmv);

        tesla.Name = "Tesla Model S";
        tesla.ModelNumber = 999;

        bmv.Name = "BMW SUPER";
        bmv.ModelNumber = 11414343;
    }
}