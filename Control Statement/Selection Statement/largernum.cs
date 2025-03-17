 using System;

class Program{

public static void Main(string[] args){
   
 int a=10, b=20,c=30;
  
  if(a>b){
    if(a>c){
      Console.WriteLine("A is the largest number");
    }
    else{
      Console.WriteLine("C is the largest number");
    }
  }
  else if(b>c){
    Console.WriteLine("B is the largest number");
  }
  
  else{
    Console.WriteLine("C is the largest number");
  }

}