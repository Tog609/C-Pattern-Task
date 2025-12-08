public class GenreFlyweight
{
    private string _name;

    public string Name
    {
        get { return _name; }
    }

    public GenreFlyweight(string name)
    {
        _name = name;
    }
}
