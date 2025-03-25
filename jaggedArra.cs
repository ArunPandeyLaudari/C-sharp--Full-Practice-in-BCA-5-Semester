using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows of the array:");

        int row = int.Parse(Console.ReadLine());

        int[][] arr = new int[row][];

        for (int i = 0; i < row; i++)
        {
            Console.WriteLine("Enter the number of columns for row " + i + ":");

            int cols = int.Parse(Console.ReadLine());

            arr[i] = new int[cols]; // Correctly initialize the jagged array

            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine("Enter the value for element [" + i + "][" + j + "]:");
                arr[i][j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("The elements of the jagged array are:");

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < arr[i].Length; j++) // Use arr[i].Length for column count
            {
                Console.Write(arr[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}