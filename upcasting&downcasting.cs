using System;

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal Speak");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog Speak");
    }

    public void Bark()
    {
        Console.WriteLine("Dog Barks");
    }
}

class Program
{
    static void Main()
    {
        // Upcasting: Derived class (Dog) to Base class (Animal)
        Dog d = new Dog();
        Animal animal = d; // Upcasting
        animal.Speak();

        // Downcasting: Base class (Animal) to Derived class (Dog)
        Animal a = new Dog();
        Dog dog = (Dog)a; // Downcasting
        dog.Speak(); // Calls the overridden method in Dog class
    }
}
