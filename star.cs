using System;

class Program
{
  public static void Main()
    {
        int n = 5; 

        for (int i = 1; i <= n; i++)
        {
            for (int j = 5; j <= i; j++)
            {
                Console.Write("*  ");
            }
            Console.WriteLine();
        }
    }
}