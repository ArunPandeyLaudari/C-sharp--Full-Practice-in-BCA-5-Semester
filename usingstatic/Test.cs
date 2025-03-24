using static System.Console;

class Test
{
    public static void Main()
    {
        int n = 5; 

        for (int i = 1; i <= n; i++)
        {
            for (int j = 5; j <= i; j++)
            {
                Write("*  ");
            }
            WriteLine();
        }
    }
}