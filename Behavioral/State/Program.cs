namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();
            character.Update();
            character.SelectState("Run");
            character.Update();
            character.SelectState("Attack");
            character.Update();
        }
    }
}
