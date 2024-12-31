using System;

public class Server
{
    public Computer Computer { get; set; }
    public string NetworkCard { get; set; }
    public string RAIDConfiguration { get; set; }
    public string PowerSupply { get; set; }

    public void Display()
    {
        Console.WriteLine($"CPU: {Computer.CPU}, RAM: {Computer.RAM}, " +
            $"Storage: {Computer.Storage}, NetworkCard: {NetworkCard}, " +
            $"RAIDConfig: {RAIDConfiguration}, PowerSupply: {PowerSupply}");
    }
}
