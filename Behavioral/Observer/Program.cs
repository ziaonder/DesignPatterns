namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            SubscriberOne subscriberOne = new SubscriberOne(publisher);
            SubscriberTwo subscriberTwo = new SubscriberTwo(publisher);
           
            // The assignment below will cause an error because the keyword "event" is used
            // for onSomethingHappened. It encapsulates the delegate and
            // only allows += and -= from outside the class

            //publisher.onSomethingHappened = null;
            publisher.DoSomething();
        }
    }
}
