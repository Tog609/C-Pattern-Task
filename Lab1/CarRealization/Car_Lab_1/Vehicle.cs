using System.Drawing;
using System.Collections.Generic;
using System.Linq;

public class Vehicle : Transport
{
    private static readonly Dictionary<int, string> _wheelDrive = new()
    {
        {1, "front"},
        {2, "back"}
    };

    private static readonly Dictionary<int, string> _class = new()
    {
        {1, "hatchback"},
        {2, "sedan"},
        {3, "coupe"}
    };

    public Color Color { get; }
    public string WheelDrive { get; }
    public string ClassType { get; }

    public Vehicle(int weight, float length, int maxSpeed, Color color, int driveType, int classType)
        : base(weight, length, maxSpeed)
    {
        Color = color;  
        WheelDrive = _wheelDrive.ContainsKey(driveType) ? _wheelDrive[driveType] : "unknown";
        ClassType = _class.ContainsKey(classType) ? _class[classType] : "unknown";
    }

    public override string ToString()
    {
        return $"Vehicle: Weight={Weight}, Length={Length}, MaxSpeed={MaxSpeed}, " +
               $"Color={Color.Name}, WheelDrive={WheelDrive}, Class={ClassType}";
    }
}
