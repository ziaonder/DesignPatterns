public class Program
{
    public static void Main(string[] args)
    {
        LegacyMessagingSystem legacy = new LegacyMessagingSystem();
        ModernAdapter adapter = new ModernAdapter(legacy);
        adapter.SendNotification("yoo");
        
        IModernNotifier modernNotifier = adapter;
        modernNotifier.SendNotification("ayaya");
    }
}