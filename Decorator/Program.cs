namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICoffee coffee = new SimpleCoffee();

            coffee = new SugarDecorator(coffee);
            coffee = new CaramelDecorator(coffee);

            Console.WriteLine(coffee.GetDescription() + " " + coffee.GetCost());
        }
    }
}
