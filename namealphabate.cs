using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of names:");
        int n = int.Parse(Console.ReadLine());

        string[] names = new string[n];

        Console.WriteLine("Enter the names:");
        for (int i = 0; i < n; i++)
        {
            names[i] = Console.ReadLine();
        }

        Array.Sort(names);

        Console.WriteLine("Names in alphabetical order:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(names[i]);
        }
    }
}
