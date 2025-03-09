using System;

public class AreaOfRect{
    public void areaOfRect(){
        Console.WriteLine("Enter the length of the rectangle: ");
        int length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the breadth of the rectangle: ");
        int breadth = Convert.ToInt32(Console.ReadLine());
        int area = length * breadth;
        Console.WriteLine("The area of the rectangle is: " + area);
    }
    
    public static void Main(string[] args){
        AreaOfRect obj = new AreaOfRect();
        obj.areaOfRect();
    }
}