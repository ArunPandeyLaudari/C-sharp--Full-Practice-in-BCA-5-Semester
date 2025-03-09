

using System;

public class Arithmetic{

    public void arithmetic(){
        Console.WriteLine("Enter the first number: ");
        int a = Convert.ToInt(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int b = Convert.ToInt(Console.ReadLine());
        int sum = a + b;
        int diff = a - b;
        int prod = a * b;
        int div = a / b;
        int mod = a % b;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + diff);
        Console.WriteLine("Product: " + prod);
        Console.WriteLine("Division: " + div);
        Console.WriteLine("Modulus: " + mod);
    }
    
    public static void Main(string[] args){
        Arithmetic obj = new Arithmetic();
        obj.arithmetic();
    }
}
