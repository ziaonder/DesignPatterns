using System;

public class StateAttack : ICharacterState
{
    public void Enter()
    {
        Console.WriteLine("Entered StateAttack");
    }

    public void Execute()
    {
        Console.WriteLine("Executing StateAttack");
    }

    public void Exit()
    {
        Console.WriteLine("Exited StateAttack");
    }
}
