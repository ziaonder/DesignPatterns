public class TechnicalSupport : SupportHandler
{
    public override void HandleRequest(string request)
    {
        if (request == "Technical Issue")
        {
            Console.WriteLine("Technical Support: Resolving technical issue.");
        }
        else
        {
            Console.WriteLine("Technical Support: Can't handle this. Escalating...");
            nextHandler?.HandleRequest(request);
        }
    }
}
