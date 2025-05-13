using System;
using System.Collections.Generic;
using System.Linq;

public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Demo
{
    static void Main()
    {
        List<Dog> dogs = new List<Dog>
        {
            new Dog { Name = "Buddy", Age = 3 },
            new Dog { Name = "Max", Age = 5 },
            new Dog { Name = "Bella", Age = 2 },
            new Dog { Name = "Charlie", Age = 4 }
        };

        // Find all dogs older than 3 years
        List<Dog> olderDogs = dogs.FindAll(d => d.Age > 3);

        foreach (var dog in olderDogs)
        {
            Console.WriteLine($"Name: {dog.Name}, Age: {dog.Age}");
        }
    }
}