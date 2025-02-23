public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override void Accept(IShapeVisitor visitor)
    {
        visitor.Visit(this);
    }
}