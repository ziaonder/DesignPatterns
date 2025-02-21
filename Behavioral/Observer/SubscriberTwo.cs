using System;

public class SubscriberTwo
{
    public SubscriberTwo(Publisher publisher)
    {
        publisher.onSomethingHappened += DoSomething;
    }

    public void DoSomething()
    {
        Console.WriteLine("SubscriberTwo laughs at you");
    }
}
