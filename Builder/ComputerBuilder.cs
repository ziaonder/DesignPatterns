using System;

public class ComputerBuilder : IComputerBuilder
{
    private Computer computer = new Computer();

    public void SetCPU(string cpu)
    {
        computer.CPU = cpu;
    }

    public void SetGPU(string gpu)
    {
        computer.GPU = gpu;
    }

    public void SetRAM(string ram)
    {
        computer.RAM = ram;
    }

    public void SetStorage(string storage)
    {
        computer.Storage = storage;
    }

    public Computer GetComputer()
    {
        return computer;
    }
}
