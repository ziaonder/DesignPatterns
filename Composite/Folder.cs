using System;

public class Folder : IFileSystemComponent
{
    private string name;
    private List<IFileSystemComponent> children = new List<IFileSystemComponent>();

    public Folder(string name)
    {
        this.name = name;
    }

    public void Add(IFileSystemComponent component)
    {
        children.Add(component);
    }

    public void ShowDetails(int depth = 0)
    {
        Console.WriteLine(new string('-', depth * 2) + "[Folder]" + name);   

        foreach(var child in children)
        {
            child.ShowDetails(depth + 1);
        }
    }
}
