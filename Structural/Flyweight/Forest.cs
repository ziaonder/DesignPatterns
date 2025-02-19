using System;

public class Forest
{
    private List<Tree> trees = new List<Tree>();

    public void PlantTree(int x, int y, string name, string color, string texture)
    {
        TreeType type = TreeFactory.GetTreeType(name, color, texture);
        Tree tree = new Tree(x, y, type);
        trees.Add(tree);
    }

    public void DisplayTrees()
    {
        foreach (var tree in trees)
        {
            tree.Display();
        }
    }
}
