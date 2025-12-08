public class AdultDecorator : LibraryItemDecorator
{
    public AdultDecorator(ILibraryItem  item) : base(item) { }

    public override string Display(int depth = 0)
    {
        string baseDisplay = base.Display(depth);

        return baseDisplay + "[18+]";
    }
}