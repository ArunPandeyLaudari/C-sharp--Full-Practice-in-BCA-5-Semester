using System;

// j panmi halna pauni asma harak datatype ko

using System.Collections;

class Program{
    static void Main(){

    Hashtable students=new Hashtable();
    students.Add(101, "Sabin");
    students.Add(102, "Subesh");
    students.Add(103, 24);
   

    foreach (DictionaryEntry entry in students) {
        Console.WriteLine("Key: " + entry.Key + " Value: " + entry.Value);
    }
     }
}

