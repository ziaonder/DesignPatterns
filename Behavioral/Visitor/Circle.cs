public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override void Accept(IShapeVisitor visitor)
    {
        visitor.Visit(this);
    }
}