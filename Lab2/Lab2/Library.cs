public class Library
{
    private List<Book> _books = new List<Book>();

    public List<Book> Books
    {
        get { return _books; }
    }
    public void AddBooks(Book book)
    {
        _books.Add(book);
    }
}