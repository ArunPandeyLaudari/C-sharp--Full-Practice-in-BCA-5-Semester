using System;
using System.Collections.Generic;
using System.Linq;


class LingTest{
    static void Main(string[] args){
        List<int> marks = new List<int>() { 10, 20, 40, 92 };
        int max = marks.Max();
        int min = marks.Min();
        int sum = marks.Sum();
        int total = marks.Count();

        Console.WriteLine("Maximum Marks: " + max);
        Console.WriteLine("Minimum Marks: " + min);
        Console.WriteLine("Sum Marks: " + sum);
        Console.WriteLine("Total counts Marks: " + total);
    }
}