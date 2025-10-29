class Program
{
    public static void Main(string[] args)
    {
        IAnimalFactory createDogFactory = new CreateDogFactory();
        var dogAnimal = createDogFactory.CreateAnimal();
        dogAnimal.LiveTime();
        IAnimalFactory createCowFactory = new CreateCowFactory();
        var cowAnimal = createCowFactory.CreateAnimal();
        cowAnimal.LiveTime();
        IAnimalFactory createCatFactory = new CreateCatFactory();
        var catAnimal = createCatFactory.CreateAnimal();
        catAnimal.LiveTime();
    }
}