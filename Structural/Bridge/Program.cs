namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRenderer vectorRanderer = new VectorRenderer();
            IRenderer rasterRenderer = new RasterRenderer();

            Shape circle = new Circle(vectorRanderer);
            Shape square = new Square(rasterRenderer);

            circle.Draw();
            square.Draw();
        }
    }
}
