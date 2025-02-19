public class ManagerSupport : SupportHandler
{
    public override void HandleRequest(string request)
    {
        Console.WriteLine("Manager: Handling escalated issue -> " + request);
    }
}
