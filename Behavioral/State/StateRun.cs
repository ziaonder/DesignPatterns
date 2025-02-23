using System;

public class StateRun : ICharacterState
{
    public void Enter()
    {
        Console.WriteLine("Entered StateRun");
    }

    public void SetState(Character character, ICharacterState state)
    {
        if(state is StateAttack)
        {
            Console.WriteLine("Can't change state. Attacking while running is not valid.");
            return;
        }

        character.SetState(state);
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
