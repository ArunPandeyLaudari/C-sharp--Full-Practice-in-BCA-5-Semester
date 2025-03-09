using System;

public class LargeNumber{

    public void largestNumber(){
        Console.WriteLine("Enter the first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int result = (a > b) ? a : b;
        Console.WriteLine("The largest number is: " + result);
    }
    
    public static void Main(string[] args){
        LargeNumber obj = new LargeNumber();
        obj.largestNumber();
    }
}