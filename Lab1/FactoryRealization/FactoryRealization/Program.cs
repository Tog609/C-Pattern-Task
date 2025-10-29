class Program
{
    public static void Main(string[] args)
    {
        CreateDogFactory createDogFactory = new CreateDogFactory();
        var dogAnimal = createDogFactory.CreateAnimal();
        dogAnimal.LiveTime();
        CreateCowFactory createCowFactory = new CreateCowFactory();
        var cowAnimal = createCowFactory.CreateAnimal();
        cowAnimal.LiveTime();
        CreateCatFactory createCatFactory = new CreateCatFactory();
        var catAnimal = createCatFactory.CreateAnimal();
        catAnimal.LiveTime();
    }
}