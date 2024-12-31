using System;

public class ModernAdapter : IModernNotifier
{
    private LegacyMessagingSystem legacySystem;

    public ModernAdapter(LegacyMessagingSystem legacySystem)
    {
        this.legacySystem = legacySystem;
    }

    public void SendNotification(string message)
    {
        legacySystem.SendMessage(message);
    }
}
