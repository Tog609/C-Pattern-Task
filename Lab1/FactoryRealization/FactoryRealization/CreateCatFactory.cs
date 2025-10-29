public class CreateCatFactory : IAnimalFactory
{
    public Ilive CreateAnimal()
    {
        return new Cat();
    }
}