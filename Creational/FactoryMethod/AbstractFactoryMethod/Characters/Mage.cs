using System;

public class Mage : Character
{
    public override void Attack()
    {
        name = "Mage";
        Console.WriteLine(name + " attacking");
    }   
}
