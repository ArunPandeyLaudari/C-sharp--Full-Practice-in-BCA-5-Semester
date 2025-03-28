using System;

class Demo
{
   public static void Main()
    {
        for (int i = 5; i >= 1; i--)
        {
            for (int j = i; j <= 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}