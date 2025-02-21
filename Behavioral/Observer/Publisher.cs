using System;

public class Publisher
{
    public delegate void OnSomethingHappened();
    public event OnSomethingHappened? onSomethingHappened;
    // or directly use Action as 
    // public event Action onSomethingHappened;
    // Action's are predefined delegates in System namespace that doesnt require to be defined

    public void DoSomething()
    {
        Console.WriteLine("Something happened");
        onSomethingHappened?.Invoke();
    }
}
