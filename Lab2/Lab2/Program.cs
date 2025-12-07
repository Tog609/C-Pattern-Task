using System.ComponentModel;

public class Program
{
    public static void Main(string[] args)
    {
        Book book = new Book(12, "Kaze Adventure", "Fantasy");
        Book book1 = new Book(13, "Lemesh Adventure", "Hentai");
        Book book2 = new Book(14, "SwingerParty", "Porn");

        var root = new Category("Books");

        var porn = new Category("Porn Books");
        var fantasy = new Category("Fantasy");
        var hentai = new Category("Hentai");

        // Fantasy
        fantasy.AddItem(book);

        // Hentai
        hentai.AddItem(book1);

        // Porn
        porn.AddItem(book2);

        root.AddItem(fantasy);
        root.AddItem(hentai);
        root.AddItem(porn);

        Console.WriteLine(root.Display() + "\n");
    }
}