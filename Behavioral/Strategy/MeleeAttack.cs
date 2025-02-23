using System;

public class MeleeAttack : IAttackStrategy
{
    public void Attack()
    {
        Console.WriteLine("Attacking melee");
    }
}
