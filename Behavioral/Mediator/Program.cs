namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chatRoom = new ChatRoom();

            User alice = new User("Alice");
            User bob = new User("Bob");
            User charlie = new User("Charlie");

            chatRoom.RegisterUser(alice);
            chatRoom.RegisterUser(bob);
            chatRoom.RegisterUser(charlie);

            alice.SendMessage("Hello, everyone!");
            bob.SendMessage("Hey, Alice!");
            charlie.SendMessage("Good morning!");
        }
    }
}
