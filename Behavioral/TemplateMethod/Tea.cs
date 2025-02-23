public class Tea : Drink
{
    public override void Brew()
    {
        Console.WriteLine("Steeping the tea");
    }

    public override void AddCondiments()
    {
        Console.WriteLine("Adding lemon");
    }
}
