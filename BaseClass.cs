using System;

class Base
{
    public virtual void Display()
    {
        Console.WriteLine("Base class Display method.");
    }
}

class Derived : Base
{

    public  override void Display()
    {
       base.Display();
        Console.WriteLine("Derived class Display method.");
    }
   
}

class Test
{
    static void Main(string[] args)
    {
        Base b = new Derived();
        b.Display(); // Calls the overridden method in Derived class
    }
}
