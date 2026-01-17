public class LibraryFacadeProxy
{
    private readonly LibraryFacade _libraryFacade;

    private readonly User _user;

    private const string _errorMessage = "You are not the admin bitch";
    public LibraryFacadeProxy(LibraryFacade libraryFacade, User user)
    {
        _libraryFacade = libraryFacade;
        _user = user;
    }
    public void AddBook(Book book)
    {
        if (_user.Role != UserRole.Admin)
        {
            Console.WriteLine(_errorMessage);
            return;
        }

        _libraryFacade.AddBook(book);
    }
    public List<Book> Search(string genre)
    {
        return _libraryFacade.Search(genre);
    }
    public string Display(ILibraryItem item)
    {
        return _libraryFacade.Display(item);
    }
}