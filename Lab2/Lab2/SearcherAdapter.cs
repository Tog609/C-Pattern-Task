public class SearcherAdapter : ISearcher
{
    private readonly INewSearcher _newSearcher;

    public SearcherAdapter(INewSearcher newSearcher)
    {
        _newSearcher = newSearcher;
    }

    public List<Book> Search(string name)
    {
        return _newSearcher.SearchByGenre(name);
    }
}