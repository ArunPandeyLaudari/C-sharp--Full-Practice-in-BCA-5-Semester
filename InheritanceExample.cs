using System;

interface A{
    int CalculateArea();
    int CalculatePerimeter();
}

class B{
    public int l,b;
    public void ReadData(int l,int b){
        this.l=l;
        this.b=b;
    }
}

class C : A {
    private B b = new B();

    public int CalculateArea() {
        b.ReadData(10, 5);
        int area = b.l + b.b;
        return area;
    }

    public int CalculatePerimeter() {
        b.ReadData(10, 5);
        int perimeter = 2 * (b.l + b.b);
        return perimeter;
    }
}


class Program{
    static void Main(String[] args){

        

    }
}
