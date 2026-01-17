public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("======= Library System Test =======\n");

        GenreFlyweightFactory genres = new GenreFlyweightFactory();

        Book bookA = new Book(100, "Cyber Mage", genres.GetGenre("Sci-Fi"));
        Book bookB = new Book(101, "Star Horizon", genres.GetGenre("Sci-Fi"));
        Book bookC = new Book(102, "Forbidden Nights", genres.GetGenre("Erotica"));
        Book bookD = new Book(103, "Dungeon Life", genres.GetGenre("Fantasy"));

        LibraryFacade facade = new LibraryFacade();

        User admin = new User("AdminUser", UserRole.Admin);
        User guest = new User("GuestUser", UserRole.User);

        LibraryFacadeProxy adminProxy = new LibraryFacadeProxy(facade, admin);
        LibraryFacadeProxy guestProxy = new LibraryFacadeProxy(facade, guest);

        Console.WriteLine("=== Guest tries to add books ===");
        guestProxy.AddBook(bookA);
        guestProxy.AddBook(bookB);
        Console.WriteLine("\n=== Admin adds books ===");
        adminProxy.AddBook(bookA);
        adminProxy.AddBook(bookB);
        adminProxy.AddBook(bookC);
        adminProxy.AddBook(bookD);
        Console.WriteLine("\n=== Guest searches for Sci-Fi books ===");
        var scifiBooks = guestProxy.Search("Sci-Fi");
        foreach (var b in scifiBooks)
            Console.WriteLine(b);

        Console.WriteLine("\n=== Composite: Category Tree ===");
        Category root = new Category("All Books");
        Category sciFi = new Category("Science Fiction");
        Category adultZone = new Category("18+ Section");

        sciFi.AddItem(bookA);
        sciFi.AddItem(bookB);

        adultZone.AddItem(bookC);

        root.AddItem(sciFi);
        root.AddItem(adultZone);
        root.AddItem(bookD);

        Console.WriteLine(facade.Display(root));

        Console.WriteLine("\n=== Decorator Example (AdultDecorator) ===");
        ILibraryItem adultDecorated = new AdultDecorator(adultZone);
        Console.WriteLine(facade.Display(adultDecorated));

        Console.WriteLine("\n=== Flyweight Check ===");
        Console.WriteLine("Sci-Fi flyweights reused: " +
            (genres.GetGenre("Sci-Fi") == genres.GetGenre("Sci-Fi")));

        Console.WriteLine("\n======= END =======");
        Console.WriteLine("Help me blyat");
    }
}
