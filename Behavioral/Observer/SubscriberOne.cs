using System;

public class SubscriberOne
{
    public SubscriberOne(Publisher publisher)
    {
        publisher.onSomethingHappened += DoSomething;
    }

    public void DoSomething()
    {
        Console.WriteLine("yo from SubscriberOne");
    }
}