using System;

interface A
{
    void MethodA(); // Method signature
}

class B
{
    public void MethodB()
    {
        Console.WriteLine("MethodB from class B");
    }
}

class C : B, A
{
    public void MethodA()
    {
        Console.WriteLine("MethodA from interface A implemented in class C");
    }

    public void MethodC()
    {
        Console.WriteLine("MethodC from class C");
    }
}

class Program
{
    static void Main(string[] args)
    {
        C obj = new C();
        obj.MethodA(); // Calling MethodA from interface A
        obj.MethodB(); // Calling MethodB from class B
        obj.MethodC(); // Calling MethodC from class C
    }
}