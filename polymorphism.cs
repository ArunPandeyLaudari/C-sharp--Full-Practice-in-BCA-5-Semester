using System;

class Addition{
    public void sum(int a,int b){
        int sum=a+b;
        Console.WriteLine("Sum"+sum);
    }
    public void sum(double a, double b){
        double d=a+b;
        Console.WriteLine("Sum"+d);
    }
    public void sum(int a,int b, int c){
        int r=a+b+c;
        Console.WriteLine("Result"+r)
    }

}

class Program{
    static void Main(String[] args){
        Addition a=new Addition();
        a.sum(5,7);
        a.sum(0.5,7.8);
        a.sum(1,2,3);

    }
}

