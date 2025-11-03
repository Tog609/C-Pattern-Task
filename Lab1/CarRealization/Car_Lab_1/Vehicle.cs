using System.Drawing;

public class Vehicle : Transport
{
    private Dictionary<int, string?> _wheelDrive = new Dictionary<int, string?>
    {
        {1, "front"},
        {2, "back"}
    };

    private string? _vehicleClass;

    private Color _color;

    public override string ToString()
    {
        return $"Vehicle: Weight={_weight}, Length={_length}, MaxSpeed={_maxSpeed}, Class={_vehicleClass}, Color = {_color} WheelDrive={string.Join(", ", _wheelDrive)}";
    }
}