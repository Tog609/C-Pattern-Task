public interface IShapeVisitor
{
    public void Visit(Cube cube);
    public void Visit(Sphere sphere);

    public void Visit(Parallelepiped parallelepiped); 

    public void Visit(Torus torus);
}