using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Sid { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Sid = 1, Name = "Alice", Marks = 85 },
            new Student { Sid = 2, Name = "Bob", Marks = 75 },
            new Student { Sid = 3, Name = "Charlie", Marks = 85 },
            new Student { Sid = 4, Name = "David", Marks = 60 }
        };

        // Example: where, orderby, group by
        var query = from s in students
                    where s.Marks >= 70
                    orderby s.Name
                    group s by s.Marks into g
                    select g;

        foreach (var group in query)
        {
            Console.WriteLine($"Marks: {group.Key}");
            foreach (var student in group)
            {
                Console.WriteLine($"  {student.Name}");
            }
        }
    }
}