using System.Drawing;
using System.Collections.Generic;

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

    public Color Color { get; }

    public Vehicle(int weight, float length, int maxSpeed, Color color)
        : base(weight, length, maxSpeed)
    {
        Color = color;
    }

    public override string ToString()
    {
        return $"Vehicle: Weight={Weight}, Length={Length}, MaxSpeed={MaxSpeed}, Color={Color}, WheelDrive={string.Join(", ", _wheelDrive)}, Class={string.Join(", ", _class)}";
    }
}
