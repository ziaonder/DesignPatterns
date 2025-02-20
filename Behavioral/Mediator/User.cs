public class User
{
    private IChatMediator _chatMediator;
    public string Name { get; }

    public User(string name)
    {
        Name = name;
    }

    public void SetChatMediator(IChatMediator chatMediator)
    {
        _chatMediator = chatMediator;
    }

    public void SendMessage(string message)
    {
        Console.WriteLine($"{Name} sends: {message}");
        _chatMediator.SendMessage(message, this);
    }

    public void ReceiveMessage(string message, User sender)
    {
        Console.WriteLine($"{Name} receives from {sender.Name}: {message}");
    }
}