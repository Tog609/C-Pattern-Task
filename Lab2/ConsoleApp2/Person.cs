public class Player
{
    public string Name;

    public int Health;

    public Player (string name, int health)
    {
        Name = name;
        Health = health;
    }
    public override string ToString()
    {
        return $"{Name} ({Health})";
    }

}
