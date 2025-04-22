using System;

abstract class Arun{
    public void msgA(){}
    Console.WriteLine("Abstract Class Method");

}

class Nabin:Arun{
    public void msgB(){
        Console.WriteLine('Inherit Class Method');
    }
}

class Program{
    static void Main(){
        Nabin n=new Nabin();
        n.msgA();
        n.msgB();
    }
}