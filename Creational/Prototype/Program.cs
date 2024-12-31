public class Program
{
    public static void Main(string[] args)
    {
        Computer computer1 = new Computer("4GB", "i5", new Monitor(60, "1920x1080"));
        Computer computer2 = (Computer)computer1.Clone();
        Computer computer3 = (Computer)computer1.Memberwise();
        computer1.CPU = "i7";
        computer1.RAM = "8GB";
        computer1.monitor.refreshRate = 120;
        computer1.monitor.resolution = "4k";

        Console.WriteLine($"cm1.RAM: {computer1.RAM} cm1.CPU: {computer1.CPU} " +
            $"cm1.monitor.refreshRate: {computer1.monitor.refreshRate} " +
            $"cm1.monitor.resolution: {computer1.monitor.resolution}\n" +
            $"cm2.RAM: {computer2.RAM} cm2.CPU: {computer2.CPU} " +
            $"cm2.monitor.refreshRate: {computer2.monitor.refreshRate} " +
            $"cm2.monitor.resolution: {computer2.monitor.resolution}");

        Console.WriteLine($"computer1.resolution: {computer1.monitor.resolution} \n" +
            $"computer3.resolution: {computer3.monitor.resolution}");

        Console.WriteLine("computer1 resolution getting changed.");
        computer1.monitor.resolution = "1024x768";
        
        Console.WriteLine($"computer1.resolution: {computer1.monitor.resolution} \n" +
            $"computer3.resolution: {computer3.monitor.resolution}");
    }    
}