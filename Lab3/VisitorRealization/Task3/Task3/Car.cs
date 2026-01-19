public abstract class Car
{
    private string _name;
    private uint _modelNumber;

    public event Action<string, object?, object?>? PropertyChanged;

    protected Car(string name, uint modelNumber)
    {
        _name = name;
        _modelNumber = modelNumber;
    }

    public string Name
    {
        get => _name;
        set
        {
            var old = _name;
            _name = value;
            PropertyChanged?.Invoke(nameof(Name), old, value);
        }
    }

    public uint ModelNumber
    {
        get => _modelNumber;
        set
        {
            var old = _modelNumber;
            _modelNumber = value;
            PropertyChanged?.Invoke(nameof(ModelNumber), old, value);
        }
    }

    public virtual string GetInfo() => $"{_name} {_modelNumber}";
}