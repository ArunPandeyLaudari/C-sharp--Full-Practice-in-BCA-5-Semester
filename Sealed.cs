using System;

class Base{
    public virtual void Display()
    {
        Console.WriteLine("Base class Display method.");
    }
}

class Derived : Base
{
    public sealed override void Display()
    {
        Console.WriteLine("Derived class Display method.");
    }
}

class Derived2:Derived{
    public override void Display()
    {
        Console.WriteLine("Derived2 class Display method.");
    }
    // This will cause a compile-time error because Display() in Derived is sealed
    // public override void Display()
}