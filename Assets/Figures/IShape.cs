public interface IShape
{
    void Draw();
}

public interface IShapeFactory
{
    IShape CreateShape();
}
