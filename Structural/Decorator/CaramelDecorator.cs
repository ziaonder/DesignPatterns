using System;

public class CaramelDecorator : CoffeeDecorator
{
    public CaramelDecorator(ICoffee coffee) : base(coffee) { }
    public override double GetCost() => base.GetCost() + 2f;
    public override string GetDescription() => base.GetDescription() + ", caramel";
}
