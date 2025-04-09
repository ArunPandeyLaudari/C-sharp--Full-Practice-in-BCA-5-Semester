using System;

using System.IO;

class Program{
    static void Main(){
        string path="example.txt";

        File.WriteAllText(path,"Hello! how are you");

        string content = File.ReadAllText(path);
        Console.WriteLine("Content of the file: "+content);
    }
}