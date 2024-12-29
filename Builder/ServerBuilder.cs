using System;

public class ServerBuilder : IComputerBuilder
{
    private Server server = new Server();

    private void InstantiateComputer()
    {
        if(server.Computer  == null)
            server.Computer = new Computer();
    }

    public void SetCPU(string cpu)
    {
        InstantiateComputer();
        server.Computer.CPU = cpu;
    }

    public void SetRAM(string ram)
    {
        InstantiateComputer();
        server.Computer.RAM = ram;
    }

    public void SetStorage(string storage)
    {
        InstantiateComputer();
        server.Computer.Storage = storage;
    }

    public void SetNetworkCard(string networkCard)
    {
        InstantiateComputer();
        server.NetworkCard = networkCard;
    }

    public void SetRAIDConfiguration(string raidConfig)
    {
        InstantiateComputer();
        server.RAIDConfiguration = raidConfig;
    }

    public void SetPowerSupply(string powerSupply)
    {
        InstantiateComputer();
        server.PowerSupply = powerSupply;
    }

    public Server GetServer()
    {
        return server;
    }

    public void SetGPU(string gpu)
    {
        throw new NotImplementedException();
    }
}
