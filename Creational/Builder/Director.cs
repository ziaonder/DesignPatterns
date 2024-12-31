using System;

public class Director
{
    public IComputerBuilder builder;

    public Director(IComputerBuilder builder)
    {
        this.builder = builder;
    }

    public void BuildGamingPC()
    {
        builder.SetCPU("Intel 13th gen or AMD comparable");
        builder.SetGPU("Either 4080 or AMD comparable someBrand");
        builder.SetRAM("32 GB someBrand");
        builder.SetStorage("2 TB SSD someBrand");
    }

    public void BuildCasualPC()
    {
        builder.SetCPU("Intel i3 10th gen or AMD comparable");
        builder.SetRAM("8 GB someBrand");
        builder.SetStorage("250 or 500 GB someBrand");
    }

    public void BuildServer()
    {
        builder.SetCPU("i5");
        builder.SetRAM("16GB");
        builder.SetStorage("1 TB HDD");
        builder.SetNetworkCard("1GbE");
        builder.SetRAIDConfiguration("RAID 1");
        builder.SetPowerSupply("1000W");
    }
}
