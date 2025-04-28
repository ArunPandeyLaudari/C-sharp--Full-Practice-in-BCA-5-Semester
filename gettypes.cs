using System;

public class Point
{
    public int x, y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

class Test
{
    public static void Main(string[] args)
    {
       Point p = new Point(5, 10);

       Console.WriteLine(p.GetType().Name);
       Console.WriteLine(typeof(Point).Name);
       Console.WriteLine(p.GetType()==typeof(Point));
       Console.WriteLine(p.x.GetType().Name);
       Console.WriteLine(p.y.GetType().FullName);
    }
}