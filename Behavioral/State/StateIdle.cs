using System;

public class StateIdle : ICharacterState
{
    public void Enter()
    {
        Console.WriteLine("Entered StateIdle");
    }

    public void SetState(Character character, ICharacterState state)
    {
        character.SetState(state);
    }

    public void Execute()
    {
        Console.WriteLine("Executing StateIdle");
    }

    public void Exit()
    {
        Console.WriteLine("Exited StateIdle");
    }
}
