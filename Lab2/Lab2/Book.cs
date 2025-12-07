public class Book : ILibraryItem
{
    private int _id;

    private string _name;

    private string _genre;

    public int Id
    {
        get { return _id; }
    }
    public string Name
    {
        get { return _name; }
    }
    public string Genre
    {
        get { return _genre; }
    }
    public Book(int id, string name, string genre)
    {
        _id = id;
        _name = name;
        _genre = genre;
    }
    public override string ToString()
    {
        return $"{Id} {Name} {Genre}";
    }
    public string Display(int depth = 0)
    {
        return new string('-', depth) + ToString();
    }
}
