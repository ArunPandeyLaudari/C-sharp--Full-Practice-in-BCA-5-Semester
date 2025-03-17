using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your grade (A, B, C, D, F): ");
        char grade = Convert.ToChar(Console.ReadLine().ToLower());

        switch (grade)
        {
            case 'A':
                Console.WriteLine("Excellent!");
                break;
            case 'B':
                Console.WriteLine("Well done!");
                break;
            case 'C':
                Console.WriteLine("Good job!");
                break;
            case 'D':
                Console.WriteLine("You passed.");
                break;
            case 'F':
                Console.WriteLine("Better luck next time.");
                break;
            default:
                Console.WriteLine("Invalid grade.");
                break;
        }
    }
}