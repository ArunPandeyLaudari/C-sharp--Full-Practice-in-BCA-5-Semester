using System;

public class Vehicle
{
    public void two_wheeler()
    {
        Console.WriteLine("This is parent bike info");
    }
}

public class Bike : Vehicle
{
    public void tvs()
    {
        Console.WriteLine("This is bike TVS info");
    }

    public static void Main(string[] args)
    {
        Bike b = new Bike();
        b.two_wheeler(); // Calling parent class method
        b.tvs(); // Calling child class method
    }
}
