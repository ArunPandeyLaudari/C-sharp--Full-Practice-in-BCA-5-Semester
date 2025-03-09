using System;

public class AreaOfCir{
    public void areaOfCir(){
        Console.WriteLine("Enter the radius of the circle: ");
        int radius = Convert.ToInt32(Console.ReadLine());
        double area = 3.14 * radius * radius;
        Console.WriteLine("The area of the circle is: " + area);
    }
    
    public static void Main(string[] args){
        AreaOfCir obj = new AreaOfCir();
        obj.areaOfCir();
    }
}