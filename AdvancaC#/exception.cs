// Exception handling in C#
//They are handled using try-catch-finally,throw blocks
using System;

class Demo:Exception {

    public void sum(int a, int b) {

        try {
            int divs = a / b;
            Console.WriteLine(divs);
        }
        catch (Exception e) {
            Console.WriteLine(e);
        }
        finally {
            Console.WriteLine("Execution completed.");
        }
    }
    public static void Main(string[] args)
    {
    {

        Demo d=new Demo();
        d.sum(10,0);

    }
}
}
