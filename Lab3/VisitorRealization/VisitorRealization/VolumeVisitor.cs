public class VolumeVisitor : IShapeVisitor
{
    private double _volume;

    public double Volume
    {
        get { return _volume; }
        private set { _volume = value; }
    }

    public void Visit(Sphere s)
    {
        Volume = 4.0 / 3.0 * Math.PI * Math.Pow(s.Radius, 3);
    }

    public void Visit(Parallelepiped p)
    {
        Volume = p.ASide * p.BSide * p.CSide;
    }

    public void Visit(Torus t)
    {
        Volume = 2 * Math.PI * Math.PI * t.RDistance * Math.Pow(t.Radius, 2);
    }

    public void Visit(Cube cube)
    {
        Volume = Math.Pow(cube.Side, 3);
    }
}
