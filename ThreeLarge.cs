// Write a program to find the largest of three numbers using nested if else.

using System;

public class ThreeLarge{
    public void largestNumber(){
        Console.WriteLine("Enter the first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the third number: ");
        int c = Convert.ToInt32(Console.ReadLine());
        int result = (a > b) ? (a > c ? a : c) : (b > c ? b : c);
        Console.WriteLine("The largest number is: " + result);
    }
    
    public static void Main(string[] args){
        ThreeLarge obj = new ThreeLarge();
        obj.largestNumber();
    }
}
