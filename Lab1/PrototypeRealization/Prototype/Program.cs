class Program
{
    public static void Main(string[] args)
    {
        IAnimal Cow = new Cow();
        Cow.SetName("Dubina");

        IAnimal Cow1 = Cow.Clone();
        Console.WriteLine(Cow.GetName());
        Console.WriteLine(Cow1.GetName());
    }
}