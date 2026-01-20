using System.Runtime.Serialization;

public class Program
{
    public static void Main(string[] args)
    {
        List <IShape> shapes =new List <IShape> ();
        IShape cube = new Cube(12);
        IShape torus = new Torus(12,14);
        IShape parallelepiped = new Parallelepiped(1,2,3);
        IShape sphere = new Sphere(14);
        shapes.Add(cube);
        shapes.Add(torus);
        shapes.Add(parallelepiped);
        shapes.Add(sphere);
        var visitor = new VolumeVisitor();
        foreach(var items in shapes)
        {
            items.Approve(visitor);
            Console.WriteLine($"Volume: {visitor.Volume:F3}");
        }
    }
}