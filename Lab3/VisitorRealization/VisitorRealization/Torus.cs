public class Torus : IShape
{
    private double _rDistance;

    private double _radius;

    public double RDistance
    {
        get { return _rDistance; } 
    }
    public double Radius
    {
        get { return _radius; }
    }
    public Torus (double RDistance, double radius)
    {
        if (RDistance <= 0 || radius<=0)
        {
            throw new ArgumentException("BadValue");
        }
        _rDistance = RDistance;
        _radius = radius;
    }
    public void Accept(IShapeVisitor shapeVisitor)
    {
        shapeVisitor.Visit(this);
    }
}