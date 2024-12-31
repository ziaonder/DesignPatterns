public interface IComputerBuilder
{
    // This interface violates the Interface Segregation Principle but we want to
    // control from a single interface. To prevent it, seperate interfaces could be used.
    public IComputerBuilder SetCPU(string cpu);
    public IComputerBuilder SetGPU(string gpu);
    public IComputerBuilder SetRAM(string ram);
    public IComputerBuilder SetStorage(string storage);
    public void SetNetworkCard(string networkCard) { }
    public void SetRAIDConfiguration(string raidConfig) { }
    public void SetPowerSupply(string powerSupply) { }
}

