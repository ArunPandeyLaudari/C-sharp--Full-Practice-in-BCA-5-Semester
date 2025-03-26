using System;

class AddMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows and columns of the matrices:");
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix1 = new int[rows, cols];
        int[,] matrix2 = new int[rows, cols];
        int[,] result = new int[rows, cols];

        Console.WriteLine("Enter elements of the first matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"matrix1[{i},{j}]: ");
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter elements of the second matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"matrix2[{i},{j}]: ");
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Adding the two matrices...");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        Console.WriteLine("Resultant Matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(result[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}