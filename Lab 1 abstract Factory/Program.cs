class Program
{
    static void Main (string[] args)
    {
        UgiuFactory factory = new WindowsFabric();
        var Windowbutton = factory.CreateButton();
        var Windowwindow = factory.CreateWindow();
        Windowbutton.Render();
        Windowwindow.Render();
    }
}