using System;

// Define an interface
interface IAnimal
{
    void Speak();
    void Eat();
}

// Implement the interface in a class

class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("The dog barks.");
    }

    public void Eat()
    {
        Console.WriteLine("The dog eats food.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IAnimal myDog = new Dog();
        myDog.Speak();
        myDog.Eat();
    }
}
