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
}


