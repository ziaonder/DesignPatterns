namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drink tea = new Tea();
            tea.PrepareRecipe();

            Console.WriteLine();

            Drink coffee = new Coffee();
            coffee.PrepareRecipe();
        }
    }
}
