public class Sphere : IShape
{
    private double  _radius;    

    public double Radius
    {
        get { return _radius; }
    }
    public Sphere(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Bad Value");
        }
        _radius = radius;
    }
    public void Approve(IShapeVisitor visitor)
    {
        visitor.Visit(this);
    }
}