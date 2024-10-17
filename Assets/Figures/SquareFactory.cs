public class SquareFactory : IShapeFactory
{
    public IShape CreateShape()
    {
        return new Square();
    }
}