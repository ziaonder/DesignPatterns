namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forest forest = new Forest();
            forest.PlantTree(1, 2, "Oak", "Green", "Rough");
            forest.PlantTree(3, 4, "Pine", "Green", "Smooth");
            forest.PlantTree(5, 6, "Oak", "Green", "Rough");
            forest.PlantTree(7, 8, "Pine", "Green", "Smooth");
            forest.DisplayTrees();
        }
    }
}
