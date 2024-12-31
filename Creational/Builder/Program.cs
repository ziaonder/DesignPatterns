public class Program
{
    public static void Main(string[] args)
    {
        ComputerBuilder builder = new ComputerBuilder();
        Computer computer = builder.GetComputer();
        computer.Display();

        builder.SetCPU("Intel i3 12th gen")
        .SetGPU("someBrand Nvidia 1050 2GB")
        .SetRAM("16 GB someBrand")
        .SetStorage("1 TB SSD someBrand");
        computer = builder.GetComputer();
        computer.Display();

        Director director = new Director(builder);
        
        director.BuildGamingPC();
        computer = builder.GetComputer();
        computer.Display();

        director.BuildCasualPC();
        computer = builder.GetComputer();
        computer.Display();

        Console.WriteLine("\n ------------------------------------------------- \n");

        // The purpose of using ServerBuilder here is to show how loosely coupled the
        // structure is by using common interfaces.
        ServerBuilder serverBuilder = new ServerBuilder();
        Server server = serverBuilder.GetServer();
        director.builder = serverBuilder;
        director.BuildServer();
        server = serverBuilder.GetServer();
        server.Display();
    }
}