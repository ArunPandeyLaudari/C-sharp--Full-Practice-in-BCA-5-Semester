using System;

public class SimpleInterest{
    public void simpleInterest(){
        Console.WriteLine("Enter the principal amount: ");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the rate of interest: ");
        int r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the time period: ");
        int t = Convert.ToInt32(Console.ReadLine());
        int si = (p * r * t) / 100;
        Console.WriteLine("The simple interest is: " + si);
    }
    
    public static void Main(string[] args){
        SimpleInterest obj = new SimpleInterest();
        obj.simpleInterest();
    }
}