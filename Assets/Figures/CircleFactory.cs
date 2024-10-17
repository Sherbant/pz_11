public class CircleFactory : IShapeFactory
{
    public IShape CreateShape()
    {
        return new Circle();
    }
}