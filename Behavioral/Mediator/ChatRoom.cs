public class ChatRoom : IChatMediator
{
    private readonly List<User> _users = new List<User>();

    public void RegisterUser(User user)
    {
        _users.Add(user);
        user.SetChatMediator(this);
    }

    public void SendMessage(string message, User sender)
    {
        foreach (var user in _users)
        {
            if (user != sender)  
            {
                user.ReceiveMessage(message, sender);
            }
        }
    }
}