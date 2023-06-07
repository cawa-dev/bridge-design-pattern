namespace Bridge;

public abstract class Shape
{
    protected Color _color;

    public Shape(Color color)
    {
        _color = color;
    }

    public abstract string draw();
}