using System;

class Person
{
}

class Employee : Person
{
    public void employee_details( string e)
    {
        Console.WriteLine("This is "+e+" Class");
    }
}

class Manager : Employee
{
    public void department(string m)
    {
        Console.WriteLine("This is "+m+" class");
    }

    public static void Main(string[] args)
    {
        Manager m = new Manager();
        m.employee_details("Employee");
        m.department("Manager");      
    }
}