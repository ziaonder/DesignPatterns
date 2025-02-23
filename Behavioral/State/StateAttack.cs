using System;

public class StateAttack : ICharacterState
{
    public void Enter()
    {
        Console.WriteLine("Entered StateAttack");
    }

    public void SetState(Character character, ICharacterState state)
    {
        if(state is StateRun)
        {
            Console.WriteLine("Can't change state. Running while attacking is not valid.");
            return;
        }

        character.SetState(state);
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
