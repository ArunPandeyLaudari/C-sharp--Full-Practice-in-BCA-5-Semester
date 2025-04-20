using System;


class Vehicle{

}

class Car:Vehicle{

    public void carName(string name){
        Console.WriteLine("The Car is " + name);
    }

    
}
class Truck:Vehicle{
     public void truckName(string name){
        Console.WriteLine("The Truck is " + name);
    }

}
class MoterCycle:Vehicle{

     public void moterName(string name){
        Console.WriteLine("The MoterCycle is " + name);
    }

}
class Program{
    public static void Main(String[] args){
        Car c=new Car();
        Truck t=new Truck();
        MoterCycle m=new MoterCycle();

        c.carName("farari");
        t.truckName("tata");
        m.moterName("E Bike");

    }
}




