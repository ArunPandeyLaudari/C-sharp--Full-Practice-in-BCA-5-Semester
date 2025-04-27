
using Sytem;

class Complex{
    private int x;
    private int y;

    public Complex(){
      
    }

    public Complex(int a, int b){
        x = a;
        y = b;
    }

    public void Show(){
        Console.WriteLine("x = {0}, y = {1}", x, y);
    }

    public static Complex operator +(Complex a, Complex b){
        Complex c = new Complex();
        c.x = a.x + b.x;
        c.y = a.y + b.y;
        return c;
    }
    public static Complex operator -(Complex a, Complex b){
        Complex c = new Complex();
        c.x = a.x - b.x;
        c.y = a.y - b.y;
        return c;
    }   

    public static Complex operator *(Complex a, Complex b){
        Complex c = new Complex();
        c.x = a.x * b.x - a.y * b.y;
        c.y = a.x * b.y + a.y * b.x;
        return c;
    }
    public static Complex operator /(Complex a, Complex b){
        Complex c = new Complex();
        c.x = (a.x * b.x + a.y * b.y) / (b.x * b.x + b.y * b.y);
        c.y = (a.y * b.x - a.x * b.y) / (b.x * b.x + b.y * b.y);
        return c;
    }
}

class Program{
    static void Main(string[] args){
        Complex a = new Complex(1, 2);
        Complex b = new Complex(3, 4);
        Complex c = new Complex();
        c = a + b;
        c.Show();
        c = a - b;
        c.Show();
        c = a * b;
        c.Show();
        c = a / b;
        c.Show();
    }
}