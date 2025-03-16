// recursive factorial
using System;

public class RecursiveFact{
    public static int Factorial(int n){
        if(n==0){
            return 1;
        }
        else{
            return n*Factorial(n-1);
        }
    }
    public static void Main(string[] args){
        int n=5;
        Console.WriteLine("Factorial of "+n+" is "+Factorial(n));
    }
}