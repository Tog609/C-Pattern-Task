public class CreateDogFactory: IAnimalFactory
{
    public Ilive CreateAnimal()
    {
        return new Dog();
    }
}