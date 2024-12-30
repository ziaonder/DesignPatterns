using System;
using System.Reflection.Metadata;

public class Archer : Character
{
    public override void Attack()
    {
        name = "Archer";
        Console.WriteLine(name + " attacking");
    }
}
