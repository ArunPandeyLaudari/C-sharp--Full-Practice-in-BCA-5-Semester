using System;

class Program{

    public static void Main(){
        int cp, sp, profit, loss;
        Console.WriteLine("Enter the cost price:");
        cp = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the selling price:");
        sp = int.Parse(Console.ReadLine());

        if(sp>cp){
            profit = sp-cp;
            Console.WriteLine("Profit is "+profit);
        }
        else if(cp>sp){
            loss = cp-sp;
            Console.WriteLine("Loss is "+loss);
        }
        else{
            Console.WriteLine("No profit no loss");
        }
    }
}