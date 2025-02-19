using System;

public class BasicSupport : SupportHandler
{
    public override void HandleRequest(string request)
    {
        if (request == "General Inquiry")
        {
            Console.WriteLine("Basic Support: Handling general inquiry.");
        }
        else
        {
            Console.WriteLine("Basic Support: Can't handle this. Forwarding...");
            nextHandler?.HandleRequest(request);
        }
    }
}
