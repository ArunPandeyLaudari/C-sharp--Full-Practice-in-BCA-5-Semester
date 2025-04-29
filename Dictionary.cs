using System.Collections.Generic;

class Program{
    static void Main(string[] args){
        Dictionary<int, string> obj = new Dictionary<int, string>();

        obj.Add(1, "Sabin");
        obj.Add(2, "devi");
        obj.Add(3, "prmi");
        obj.Add(4, "kumari");
        obj.Add(5, "sital");
        obj.Add(6, "depa");
        obj.Add(7, "bain");

        foreach (var kvp in obj)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }
}