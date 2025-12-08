public class GenreFlyweightFactory
{
    private Dictionary<string, GenreFlyweight> _genres = new();

    public GenreFlyweight GetGenre(string name)
    {
        if (!_genres.ContainsKey(name))
        {
            _genres[name] = new GenreFlyweight(name);
        }
        return _genres[name];
    }
}
