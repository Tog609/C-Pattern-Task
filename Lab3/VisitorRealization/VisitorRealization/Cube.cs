public class Cube : IShape
{
    private double _side;

    public double Side
    {
        get { return _side; }
    }
    public Cube (double side)
    {
        if (side <= 0)
        {
            throw new ArgumentException("Bad Value");
        }
        _side = side;
    }
    public void Approve(IShapeVisitor visitor)
    {
        visitor.Visit(this);
    }
}