using System.Drawing;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);
            Shape square = new Square(4);

            IShapeVisitor areaVisitor = new AreaVisitor();

            circle.Accept(areaVisitor);
            rectangle.Accept(areaVisitor);
            square.Accept(areaVisitor);

            IShapeVisitor perimeterVisitor = new PerimeterVisitor();

            circle.Accept(perimeterVisitor);
            rectangle.Accept(perimeterVisitor);
            square.Accept(perimeterVisitor);
        }
    }
}
