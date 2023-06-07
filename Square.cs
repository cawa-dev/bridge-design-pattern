namespace Bridge;

public class Square : Shape
{
    public Square(Color color) : base(color)
    {
    }
    
    public override string draw()
    {
        return "Square drawn. " + _color.fill();
    }
}