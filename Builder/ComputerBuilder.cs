using System;

public class ComputerBuilder : IComputerBuilder
{
    private Computer computer = new Computer();

    public IComputerBuilder SetCPU(string cpu)
    {
        computer.CPU = cpu;
        return this;
    }

    public IComputerBuilder SetGPU(string gpu)
    {
        computer.GPU = gpu;
        return this;
    }

    public IComputerBuilder SetRAM(string ram)
    {
        computer.RAM = ram;
        return this;
    }

    public IComputerBuilder SetStorage(string storage)
    {
        computer.Storage = storage;
        return this;
    }

    public Computer GetComputer()
    {
        return computer;
    }
}
