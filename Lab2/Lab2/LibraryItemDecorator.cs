public class LibraryItemDecorator : ILibraryItem
{
    protected ILibraryItem _item;

    public LibraryItemDecorator(ILibraryItem item)
    {
        _item = item;
    }
    public virtual string Display(int depth = 0)
    {
        return _item.Display(depth);
    }
}