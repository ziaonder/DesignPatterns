using System;

public abstract class CoffeeDecorator : ICoffee
{
    public ICoffee coffee;
    public CoffeeDecorator(ICoffee coffee) => this.coffee = coffee;
    public virtual double GetCost() => coffee.GetCost();
    public virtual string GetDescription() => coffee.GetDescription();
}
