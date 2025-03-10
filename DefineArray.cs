using System;

public class DefineArray
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum=0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum+=numbers[i];
        }
        Console.WriteLine("The sum of the array is "+sum);
    }
}