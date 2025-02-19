using System;

public class Tree
{
    private int x, y;
    private TreeType type;

    public Tree(int x, int y, TreeType type)
    {
        this.x = x;
        this.y = y;
        this.type = type;
    }

    public void Display()
    {
        Console.WriteLine($"Tree at ({x}, {y}) with type: ");
        type.Display();
    }
}
