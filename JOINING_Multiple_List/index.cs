using System;
using System.Collections.Generic;
using System.Linq;

class Test
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>()
        {
            "sabin",
            "subash",
            "samith"
        };

        List<string> addresses = new List<string>()
        {
            "Kathmandu",
            "Pokhara",
            "Lalitpur"
        };

        // Method 1: Using AddRange
        List<string> combined = new List<string>(names);
        combined.AddRange(addresses);

        Console.WriteLine("Combined using AddRange:");
        foreach (var item in combined)
        {
            Console.WriteLine(item);
        }

        // Method 2: Using LINQ Concat
        var combined2 = names.Concat(addresses).ToList();

        Console.WriteLine("\nCombined using LINQ Concat:");
        foreach (var item in combined2)
        {
            Console.WriteLine(item);
        }
    }
}