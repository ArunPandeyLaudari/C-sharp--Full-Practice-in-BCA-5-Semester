public struct Point{
    public int x, y;
    public Point(int x,int y){
        this.x=x;
        this.y=y;
    }
    public Point() {
        this.x = 0;
        this.y = 0;
    }
}
class hello
{
    public static void Main()
    {
        // Point p1 = new Point();
        Point p2 = new Point(1, 2);
    }
}
