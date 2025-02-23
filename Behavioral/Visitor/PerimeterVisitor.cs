using System.Drawing;

public class PerimeterVisitor : IShapeVisitor
{
    public void Visit(Circle circle)
    {
        double perimeter = 2 * Math.PI * circle.Radius;
        Console.WriteLine($"Perimeter of Circle: {perimeter}");
    }

    public void Visit(Rectangle rectangle)
    {
        double perimeter = 2 * (rectangle.Width + rectangle.Height);
        Console.WriteLine($"Perimeter of Rectangle: {perimeter}");
    }

    public void Visit(Square square)
    {
        double perimeter = 4 * square.Side;
        Console.WriteLine($"Perimeter of Square: {perimeter}");
    }
}