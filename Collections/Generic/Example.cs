using System;

using System.Collections.Generic;


class Program{
    static void Main(){
        List<string> students=new List<string>();
        students.Add("Sabin");
        students.Add("Subesh");
        students.Add("Sanjay");
        students.Add("Bhugol");


foreach(string student in students) {
    Console.WriteLine(student); 
    }
}
}
