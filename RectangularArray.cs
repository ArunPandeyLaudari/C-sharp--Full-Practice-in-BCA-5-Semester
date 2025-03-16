using System;

public class RectangularArray{
 public static void Main(){
// asking input from user
Console.WriteLine("Enter the number of rows and columns of the array: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

// creating a 2D array
int[,] arr = new int[rows, columns];

// asking input from user
Console.WriteLine("Enter the elements of the array: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        arr[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

// displaying the array
Console.WriteLine("The elements of the array are: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
}
} 


