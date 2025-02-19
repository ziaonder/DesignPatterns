using System;

public class DatabaseProxy : IDatabase
{
    private RealDatabase _realDatabase; // No instance created initially
    private string _cachedQueryResult;
    
    public void Query(string sql)
    {
        if (_realDatabase == null)
        {
            Console.WriteLine("DatabaseProxy: Creating RealDatabase instance (lazy initialization)...");
            _realDatabase = new RealDatabase(); // Now we create the real object
        }

        // Simulated caching logic
        if (_cachedQueryResult == null)
        {
            _realDatabase.Query(sql);
            _cachedQueryResult = $"Cached result for '{sql}'";  // Store result
        }
        else
        {
            Console.WriteLine($"DatabaseProxy: Returning cached result -> {_cachedQueryResult}");
        }
    }
}
