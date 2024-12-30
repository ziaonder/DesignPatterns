using System;

public class Mage : ICharacter
{
    public string Name { get; set; } = "Mage";
    public int Health { get; set; } = 100;
    public string AttackType { get; set; } = "Ranged";

    public void DisplayStats()
    {
        Console.WriteLine(Name + " " + Health + " " + AttackType);
    }

    public void Attack()
    {
        Console.WriteLine("Mage attacking");
    }
}
