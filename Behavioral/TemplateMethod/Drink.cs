public abstract class Drink
{
    // Template method
    public void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
    }

    // These are the steps that will be the same for all drinks
    public void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    public void PourInCup()
    {
        Console.WriteLine("Pouring into cup");
    }

    // These are the steps that will be overridden by subclasses
    public abstract void Brew();
    public abstract void AddCondiments();
}
