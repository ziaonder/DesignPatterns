using System;

public class RealDatabase
{
    public RealDatabase()
    {
        Console.WriteLine("RealDatabase: Connecting to the database (expensive operation)...");
        // Simulating time-consuming initialization
        Thread.Sleep(2000);
    }

    public void Query(string sql)
    {
        Console.WriteLine($"RealDatabase: Executing query -> {sql}");
    }
}
