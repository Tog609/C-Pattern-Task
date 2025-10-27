public class WindowsFabric : UgiuFactory
{
    public IButton CreateButton()
    {
        return new WindowButton();
    }
    public IWindow CreateWindow()
    {
        return new WindowsWindow();
    }
}