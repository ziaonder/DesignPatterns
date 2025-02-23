namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();
            character.Update();
            character.AttemptToChangeState("Run");
            character.Update();
            character.AttemptToChangeState("Attack");
            character.Update();
        }
    }
}
