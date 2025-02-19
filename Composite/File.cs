using System;

public class File : IFileSystemComponent
{
    private string name;

    public File(string name)
    {
        this.name = name;
    }

    public void ShowDetails(int depth = 0)
    {
        Console.WriteLine(new string('-', depth * 2) + name);   
    }
}
