using System;

public class Factorial{
    public static void Main(string[] args){
        int fact=1;
        int n=5;

        for(int i=1;i<=n;i++){
            fact*=i;
        }

        Console.WriteLine("Factorial of "+n+" is "+fact);
    }
}