using System;


class MyClass{
    private int x;
    public void Setx(int i){
        x=i;
    }

    public int Getx(){
        return x;
    }
}

class Program{
    static void Main(){
        MyClass obj=new MyClass();
        obj.Setx(10);
        int val=obj.Getx();
        Console.WriteLine('Value:'+val)
    }
}