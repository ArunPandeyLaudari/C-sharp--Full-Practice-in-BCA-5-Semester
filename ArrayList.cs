using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Create an ArrayList
        ArrayList arrayList = new ArrayList();

        // Add elements to the ArrayList
        arrayList.Add(1);
        arrayList.Add("Hello");
        arrayList.Add(3.14);
        arrayList.Add(true);

        // Display the elements in the ArrayList
        Console.WriteLine("ArrayList elements:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        // Remove an element
        arrayList.Remove(1);

        // Display the elements after removal
        Console.WriteLine("\nArrayList elements after removal:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        // Access an element by index
        Console.WriteLine("Element at index 1: "+arrayList[1]);
    }
}