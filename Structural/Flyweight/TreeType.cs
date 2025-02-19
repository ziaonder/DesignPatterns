using System;

// shared data(intrinsic)
public class TreeType
{
    public string Name { get; }
    public string Color { get; }
    public string Texture { get; }

    public TreeType(string name, string color, string texture)
    {
        Name = name;
        Color = color;
        Texture = texture;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Color: {Color}, Texture: {Texture}");
    }
}
