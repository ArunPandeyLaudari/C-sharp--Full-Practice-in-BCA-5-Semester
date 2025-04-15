using System;

static class Person{
    public static int id;
    public static String name;

    public static void Display(){
        Console.WriteLine("Id=" + id + " Name=" + name);
    }
}

class Program{
    static void Main(String[] args){
        Person.id = 12;
        Person.name="Arun";
        Person.Display();
    }
}