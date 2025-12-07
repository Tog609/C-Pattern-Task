public class LibrarySorting : INewSearcher
{
    private readonly Library _library;

    public LibrarySorting(Library library)
    {
        _library = library;
    }

    public List<Book> SearchByGenre(string genre)
    {
        return _library.Books.Where(book => book.Genre == genre).ToList();
    }
}