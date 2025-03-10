using System;

public class AskingArray{
    public static void Main(string[] args){
        Console.WriteLine("Enter the size of the array:");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] num = new int[size];
        int sum = 0;

        for(int i = 0; i < size; i++){
            Console.WriteLine("Enter element " + (i + 1) + ":");
            num[i] = Convert.ToInt32(Console.ReadLine());
            sum += num[i];
        }

        Console.WriteLine("The sum of the array elements is: " + sum);
    }
}