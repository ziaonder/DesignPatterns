public class Coffee : Drink
{
    public override void Brew()
    {
        Console.WriteLine("Dripping coffee through filter");
    }

    public override void AddCondiments()
    {
        Console.WriteLine("Adding sugar and milk");
    }
}