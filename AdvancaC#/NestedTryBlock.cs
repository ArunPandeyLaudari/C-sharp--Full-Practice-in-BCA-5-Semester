using System;

class Program{
    static void Main(string[] args){
        var d=0;

        try{
            var r =100/d;
            try{
                var r=100/d;
            }
            catch{
                Console.WriteLine('Inner Catch')
            }
        }
        catch{
            Console.WriteLine("Outer Catch")
        }
    }
}