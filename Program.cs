using Bridge;

class Program
{
    public static void Main(string[] args)
    {
        Shape square = new Square(new Blue());

        Console.WriteLine(square.draw());
    }
}