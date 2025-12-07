
public class Category : ILibraryItem
{
    private List<ILibraryItem> _libraryItems = new List<ILibraryItem>();

    private  string _name;

    public string Name
    {
        get { return _name; }
    }
    public Category(string name)
    {
        _name = name;
    }
    public void AddItem(ILibraryItem item)
    {
        _libraryItems.Add(item);
    }
    public string Display(int depth = 0)
    {
        string result = $"{new string('-', depth)}{Name}\n";
        foreach (var item in _libraryItems)
        {
            result += item.Display(depth + 2) + "\n";
        }

        return result;
    }
}