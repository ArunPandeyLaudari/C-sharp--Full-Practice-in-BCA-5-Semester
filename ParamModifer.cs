using System;

class Program{
    static void Sum(params int[] numbers){
        int sum=0;
        for(int i=0; i<numbers.Length; i++){
            sum += numbers[i];
        }
        Console.WriteLine("Sum: "+sum);
    }
    public static void Main(string[] args){
        Sum(1,2,3,4,5);
        Sum(10,20,30,40,50);
        Sum(100,200,300,400,500);
    }
}