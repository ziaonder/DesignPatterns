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
        state.Enter();
    }

    public void AttemptToChangeState(string stateName)
    {
        switch (stateName)
        {
            case "Idle":
                if (state == idle)
                    return;
                else
                    state.SetState(this, idle);
                break;
            case "Run":
                if (state == run)
                    return;
                else
                    state.SetState(this, run);
                break;
            case "Attack":
                if (state == attack)
                    return;
                else
                    state.SetState(this, attack);
                break;
            default:
                return;
        }
    }

    public void SetState(ICharacterState newState)
    {
        state.Exit();
        state = newState;
        state.Enter();
    }

    public void Update()
    {
        state.Execute();
    }
}
