public class LibraryFacade
{
    private Library _library;

    private ISearcher _searcher;

    public LibraryFacade()
    {
        _library = new Library();

        INewSearcher newSearcher = new LibrarySorting(_library);

        _searcher = new SearcherAdapter(newSearcher);
    }
    public void AddBook(Book book)
    {
        _library.AddBooks(book);
    } 

    public List<Book> Search(string genre)
    {
        return _searcher.Search(genre);
    }
    public string Display(ILibraryItem item)
    {
        return item.Display();
    }
}