namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var basicSupport = new BasicSupport();
            var technicalSupport = new TechnicalSupport();
            var managerSupport = new ManagerSupport();

            basicSupport.SetNext(technicalSupport);
            technicalSupport.SetNext(managerSupport);

            Console.WriteLine("\nRequest 1: General Inquiry");
            basicSupport.HandleRequest("General Inquiry");

            Console.WriteLine("\nRequest 2: Technical Issue");
            basicSupport.HandleRequest("Technical Issue");

            Console.WriteLine("\nRequest 3: Serious Problem");
            basicSupport.HandleRequest("Serious Problem");
        }
    }
}
