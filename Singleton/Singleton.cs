using System;

public class Singleton
{
    private static Singleton instance;

    private Singleton()
    {
        Console.WriteLine("Singleton created");
    }

    public static Singleton Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }
    }

    public void DoSome()
    {
        Console.WriteLine("hey from singleton");
    }
}
