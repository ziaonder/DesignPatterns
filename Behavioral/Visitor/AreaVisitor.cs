using System.Drawing;

public class AreaVisitor : IShapeVisitor
{
    public void Visit(Circle circle)
    {
        double area = Math.PI * Math.Pow(circle.Radius, 2);
        Console.WriteLine($"Area of Circle: {area}");
    }

    public void Visit(Rectangle rectangle)
    {
        double area = rectangle.Width * rectangle.Height;
        Console.WriteLine($"Area of Rectangle: {area}");
    }

    public void Visit(Square square)
    {
        double area = Math.Pow(square.Side, 2);
        Console.WriteLine($"Area of Square: {area}");
    }
}