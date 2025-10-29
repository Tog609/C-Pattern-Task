public class CreateCowFactory : IAnimalFactory
{
    public Ilive CreateAnimal()
    {
        return new Cow();
    }
}