public class TriangleFactory : IShapeFactory
{
    public IShape CreateShape()
    {
        return new Triangle();
    }
}