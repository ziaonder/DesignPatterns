using System;

public class StateRun : ICharacterState
{
    public void Enter()
    {
        Console.WriteLine("Entered StateRun");
    }

    public void Execute()
    {
        Console.WriteLine("Executing StateRun");
    }

    public void Exit()
    {
        Console.WriteLine("Exited StateRun");
    }
}
