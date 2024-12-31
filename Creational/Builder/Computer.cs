using System;

public class Computer
{
    public string CPU { get; set; } = "None";
    public string GPU { get; set; } = "None";
    public string RAM { get; set; } = "None";
    public string Storage { get; set; } = "None";

    public void Display()
    {
        Console.WriteLine($"CPU: {CPU}, GPU: {GPU}, RAM: {RAM}, Storage: {Storage}");
    }
}
