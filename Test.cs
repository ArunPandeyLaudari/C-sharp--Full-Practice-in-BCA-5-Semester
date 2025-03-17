using System;

public class Test {
    public static void Main(string[] args) {
        int i = 1;
        int sum = 0;

        do {
            sum += i;
            i++;
        } while (i <= 25);

        Console.WriteLine(sum);
    }
}