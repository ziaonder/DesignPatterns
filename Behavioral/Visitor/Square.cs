public class Square : Shape
{
    public double Side { get; set; }

    public Square(double side)
    {
        Side = side;
    }

    public override void Accept(IShapeVisitor visitor)
    {
        visitor.Visit(this);
    }
}