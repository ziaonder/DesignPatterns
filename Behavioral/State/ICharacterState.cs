// This state template can be either an interface or an abstract class. Interface was enough here.

public interface ICharacterState
{
    public void Enter();
    public void Execute();
    public void Exit();
}

