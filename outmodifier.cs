// what is OutModifier

using System;

class Program {
    static void outMod(out int x, out int y) {
        x = 10;
        y = 20;
    }

    public static void Main(string[] args) {
        // Declare two integer variables
        int a, b;

        // Call the outMod method with out parameters
        outMod(out a, out b);

        // Print the values of a and b
        Console.WriteLine("a: " + a + " b: " + b);
    }
}