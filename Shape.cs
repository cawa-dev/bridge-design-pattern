namespace Bridge;

public abstract class Shape
{
    protected Color _color;

    protected Shape(Color color)
    {
        _color = color;
    }

    public abstract string draw();
}