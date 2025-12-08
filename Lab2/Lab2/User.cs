public class User
{
    private string _name;
    private UserRole _role;

    public string Name
    {
        get {return _name;}
    }
    public UserRole Role
    {
        get {return _role;}
    }
    public User(string name, UserRole role)
    {
        _name = name;
        _role = role;
    }
}
