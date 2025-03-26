using System;


namespace outer{
    class DisplayClass{
        public void Display(){
            Console.WriteLine("Outer Display");
        }
    }



namespace Inner{

    class DisplayClass{
        public void Display(){
            Console.WriteLine("Inner Display");
        }

    }
}
}


class Program{
    static void Main(){
        outer.DisplayClass outer=new outer.DisplayClass();
        outer.Display();

        Inner.DisplayClass inner=new Inner.DisplayClass();
        inner.Display();
    }
}