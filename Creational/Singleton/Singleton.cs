using System;

public class Singleton
{
    private static Singleton instance;

    // Private constructor to prevent instantiation.
    // Only Instance property can instantiate an instance of this class if there is none.
    private Singleton()
    {
        Console.WriteLine("Singleton created");
        instance = this;
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
