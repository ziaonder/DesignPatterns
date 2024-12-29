public interface IComputerBuilder
{
    // This interface violates the Interface Segregation Principle but we want to
    // control from a single interface. To prevent it, seperate interfaces could be used.
    public void SetCPU(string cpu);
    public void SetGPU(string gpu);
    public void SetRAM(string ram);
    public void SetStorage(string storage);
    public void SetNetworkCard(string networkCard) { }
    public void SetRAIDConfiguration(string raidConfig) { }
    public void SetPowerSupply(string powerSupply) { }
}

