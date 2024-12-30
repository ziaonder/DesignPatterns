// There are 2 types of copying: Shallow Copy and Deep Copy. The distinction is about
// how value types and reference types are handled during the copying process.

// Copying value types is simple, only the value is copied. However, references are
// not. Assigning a reference type to another will result in sharing the same reference.
// Their memory addresses copied, not the actual object. Any changes on both of
// them will cause the same change on the other(s). This is actually what shallow
// copy is, copying the reference.

// If we only want the value of that reference type without sharing the same reference
// we do deep copying. Deep copying is basically creating a new instance of the
// mentioned reference type and copying the value types of it.

using System;

public class Monitor
{
    public int refreshRate;
    public string resolution;

    public Monitor(int refreshRate, string resolution)
    {
        this.refreshRate = refreshRate;
        this.resolution = resolution;
    }
}

public class Computer : IPrototype
{
    public string RAM { get; set; }
    public string CPU { get; set; }
    public Monitor monitor;

    public Computer(string RAM, string CPU, Monitor monitor)
    {
        this.RAM = RAM;
        this.CPU = CPU;
        this.monitor = monitor;
    }

    public IPrototype Clone()
    {
        return new Computer(this.RAM, this.CPU, 
            new Monitor(this.monitor.refreshRate, this.monitor.resolution));
    }

    public IPrototype Memberwise()
    {
        // This is a predefined method from object class that clones all fields 
        // Value types are copied, reference types are shared.
        return (Computer)this.MemberwiseClone();
    }
}
