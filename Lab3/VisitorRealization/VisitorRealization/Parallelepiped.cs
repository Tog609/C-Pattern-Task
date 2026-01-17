
public class Parallelepiped : IShape
{
    private double _aSide;

    private double _bSide;

    private double _cSide;

    public double ASide
    {
        get { return _aSide; } 
    }
    public double BSide
    {
        get { return _bSide; }
    }
    public double CSide
    {
        get { return _cSide; }
    }
    public Parallelepiped (double ASide, double BSide, double CSide)
    {
        if (ASide <= 0 && BSide <=0 & CSide <=0)
        {
            throw new ArgumentException("Bad Value");
        }
        _aSide = ASide;
        _bSide = BSide;
        _cSide = CSide;
    }
    public void Accept(IShapeVisitor shapeVisitor)
    {
        shapeVisitor.Visit(this);
    }
}