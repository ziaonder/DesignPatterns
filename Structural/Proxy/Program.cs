namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client: Using the database through a proxy.");

            IDatabase database = new DatabaseProxy();

            Console.WriteLine("\nFirst query (should initialize RealDatabase):");
            database.Query("SELECT * FROM users");

            Console.WriteLine("\nSecond query (should use cached result):");
            database.Query("SELECT * FROM users");

            Console.WriteLine("\nAnother query (should still use the same instance of RealDatabase):");
            database.Query("SELECT * FROM orders");
        }
    }
}
