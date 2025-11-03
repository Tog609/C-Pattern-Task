public class Tank : Transport
{
    private float _projectileColiber;

    private int _shotsPerMinute;

    private float _crewSize;

    public sealed override string ToString()
    {
        return $"{_projectileColiber},{_shotsPerMinute}, {_crewSize}";
    }
}