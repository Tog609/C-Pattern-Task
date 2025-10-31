public class Cow : IAnimal
{
    private string? _name;

    public Cow() { } 
    private Cow(Cow donor) => this._name = donor._name;

    public void SetName(string name)
    {
        this._name = name;
    }
    public string? GetName()
    {
        return this._name;
    }
    public IAnimal Clone()
    {
        return new Cow(this);
    }
}