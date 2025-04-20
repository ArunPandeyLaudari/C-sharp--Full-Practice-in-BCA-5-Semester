using System;

interface Rose{

    void roseColor(string color);
      
    
}

interface Lily{

    void lilyColor(string color);
}


class Flower : Rose, Lily {
    public void roseColor(string color) {
        Console.WriteLine("Rose color is: " + color);
    }

    public void lilyColor(string color) {
        Console.WriteLine("Lily color is: " + color);
    }

    public static void Main(String[] args) {
        Flower f = new Flower();
        f.roseColor("Red");
        f.lilyColor("White");
    }
}