public class PeopleList
{
    private HashSet<Person> _people = new HashSet<Person>();

    public HashSet<Person> People
    {
        get { return _people; }
    }

    public void AddPeople(Person person)
    {
        _people.Add(person);
    }

}