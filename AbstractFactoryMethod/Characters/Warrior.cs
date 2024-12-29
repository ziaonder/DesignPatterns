using System;

public class Warrior : Character
{
    public override void Attack()
    {
        name = "Warrior";
        Console.WriteLine(name + " attacking");
    }
}
