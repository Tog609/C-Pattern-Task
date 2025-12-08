public class SearcherAdapter : ISearcher
{
    private readonly INewSearcher _newSearcher;

    public SearcherAdapter(INewSearcher newSearcher)
    {
        _newSearcher = newSearcher;
    }

    public List<Book> Search(string genre)
    {
        return _newSearcher.SearchByGenre(genre);
    }
}