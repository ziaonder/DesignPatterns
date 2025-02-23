using System;

public class Character
{
    StateIdle idle = new StateIdle();
    StateRun run = new StateRun();
    StateAttack attack = new StateAttack();
    ICharacterState state;

    public Character()
    {
        state = idle;
    }

    public void SelectState(string stateName)
    {
        ICharacterState newState = null;

        switch (stateName)
        {
            case "Idle":
                if (state == idle)
                    return;
                else
                    newState = idle;
                break;
            case "Run":
                if (state == run)
                    return;
                else
                    newState = run;
                break;
            case "Attack":
                if (state == attack)
                    return;
                else
                    newState = attack;
                break;
            default:
                return;
        }

        // The code will reach here only if the state is changed
        state.Exit();
        state = newState;
        state.Enter();
    }

    public void Update()
    {
        state.Execute();
    }
}
