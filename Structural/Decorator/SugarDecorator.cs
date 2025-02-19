using System;

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }
    public override double GetCost() => base.GetCost() + .5f;
    public override string GetDescription() => base.GetDescription() + ", sugar";
}
