using System;

public class Player
{
    IAttackStrategy attackStrategy;

    public Player(IAttackStrategy attackStrategy)
    {
        this.attackStrategy = attackStrategy;
    }

    public void SetAttackStrategy(IAttackStrategy attackStrategy)
    {
        this.attackStrategy = attackStrategy;
    }

    public void Attack()
    {
        attackStrategy.Attack();
    }
}
