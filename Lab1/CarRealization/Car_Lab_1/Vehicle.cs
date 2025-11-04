using System.Drawing;

public class Vehicle : Transport
{
    private Dictionary<int, string?> _wheelDrive = new Dictionary<int, string?>
    {
        {1, "front"},
        {2, "back"}
    };

    private Dictionary<int, string> _class = new Dictionary<int, string>
    {
        {1,"hatchback"},
        {2, "sedan"},
        {3, "coupe"}
    };

    private Color _color;


    public sealed override string ToString()
    {
        return $"Vehicle: Weight={_weight}, Length={_length}, MaxSpeed={_maxSpeed}, Class={_class}, Color = {_color} WheelDrive={string.Join(", ", _wheelDrive)}";
    }
}