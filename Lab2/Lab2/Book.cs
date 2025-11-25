public struct Book
{
    public string Name { get; set; }

    public int Id { get; set; }

    public override string ToString()
    {
        return $"{Name} : {Id}";
    }
}