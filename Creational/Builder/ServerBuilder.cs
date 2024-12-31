using System;

public class ServerBuilder : IComputerBuilder
{
    private Server server = new Server();

    private void InstantiateComputer()
    {
        if(server.Computer  == null)
            server.Computer = new Computer();
    }

    public IComputerBuilder SetCPU(string cpu)
    {
        InstantiateComputer();
        server.Computer.CPU = cpu;
        return this;
    }

    public IComputerBuilder SetRAM(string ram)
    {
        InstantiateComputer();
        server.Computer.RAM = ram;
        return this;
    }

    public IComputerBuilder SetStorage(string storage)
    {
        InstantiateComputer();
        server.Computer.Storage = storage;
        return this;
    }

    public IComputerBuilder SetNetworkCard(string networkCard)
    {
        InstantiateComputer();
        server.NetworkCard = networkCard;
        return this;
    }

    public IComputerBuilder SetRAIDConfiguration(string raidConfig)
    {
        InstantiateComputer();
        server.RAIDConfiguration = raidConfig;
        return this;
    }

    public IComputerBuilder SetPowerSupply(string powerSupply)
    {
        InstantiateComputer();
        server.PowerSupply = powerSupply;
        return this;
    }

    public Server GetServer()
    {
        return server;
    }

    public IComputerBuilder SetGPU(string gpu)
    {
        throw new NotImplementedException();
    }
}
