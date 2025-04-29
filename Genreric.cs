using System.Collections.Generic

    class Program{

        static void Swap<T> (ref T a,ref T b){
            T temp;
            temp=a;
            a=b;
            b=temp;
        }

        static void Main(string[] args){
            int a,b=40,95;
            Console.WriteLine('Before swap a='+a+"b"+b);
            Swap<int> (ref a,ref b);
            Console.WriteLine("After Swap,a="+a+"b="+b);
        }
    }

