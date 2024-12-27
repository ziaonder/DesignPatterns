using System;

public class Archer : ICharacter
{
    public string Name { get; set; } = "Archer";
    public int Health { get; set; } = 60;
    public string AttackType { get; set; } = "Ranged";

    public void DisplayStats()
    {
        Console.WriteLine(Name + " " + Health + " " + AttackType);
    }
}