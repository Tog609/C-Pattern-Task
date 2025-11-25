public class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library();
        var a = new Book();
        a.Id = 1;
        a.Name = "Test";
        library.AddBook(a);
        foreach (var b in library)
        {
            Console.WriteLine(b);
        }
    }
}