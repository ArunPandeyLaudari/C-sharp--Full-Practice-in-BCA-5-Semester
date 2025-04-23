using System;

class Arun{

    protected virtual void hero(){
        Console.WriteLine("Hello");
    }
}


class Nabin:Arun{
    protected override void hero(){
        Console.WriteLine("World");
    }

    public static void Main(String[] args){
        Nabin n=new Nabin();

        n.hero();
    }
}