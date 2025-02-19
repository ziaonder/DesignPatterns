using System;

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }
    public override double GetCost() => base.GetCost() + 1.0f;
    public override string GetDescription() => base.GetDescription() + ", milk";
}
