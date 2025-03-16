using System;
public class Hero{
   
        public int hi(int a,int b){
            int sum=a+b;
          return sum;
        }

        
        public static void Main(string[] args){
            Hero obj=new Hero();
            Console.WriteLine(obj.hi(5,6));
            Console.WriteLine(obj.hi(10,20));
            Console.WriteLine(obj.hi(100,200));
        
        }
}