using System;

class Example
{
    ~Example()
    {
        Console.WriteLine("Finalizer called.");
    }
}

class Program
{
    static void Main()
    {
        Example obj = new Example();
        obj = null;

        // Force garbage collection to see the finalizer in action
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Program finished.");
    }
}