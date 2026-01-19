public class Container
{
    private List<Car> _cars = new List<Car>();

    public void Add(Car car)
    {
        _cars.Add(car);

        Console.WriteLine($"Added object: {car.GetType().Name}");

        car.PropertyChanged += OnCarPropertyChanged;
    }

    private void OnCarPropertyChanged(string property, object? oldValue, object? newValue)
    {
        Console.WriteLine($"Property '{property}' changed: {oldValue} -> {newValue}");
    }
}