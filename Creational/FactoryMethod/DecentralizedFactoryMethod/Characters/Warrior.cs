using System;

public class Warrior : ICharacter
{
    public string Name { get; set; } = "Warrior";
    public int Health { get; set; } = 100;
    public string AttackType { get; set; } = "Melee";

    public void DisplayStats()
    {
        Console.WriteLine(Name + " " + Health + " " + AttackType);
    }

    public void Attack()
    {
        Console.WriteLine("Warrior attacking");
    }
}
