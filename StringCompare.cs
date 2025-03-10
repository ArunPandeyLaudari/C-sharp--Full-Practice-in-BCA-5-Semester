using System;
public class StringCompare{
    public static void Main(){
    
    Console.WriteLine("Enter your name");
   string name=Console.ReadLine();
    Console.WriteLine("Enter your friend's name");
  string  friendName=Console.ReadLine();


    if(name.CompareTo(friendName)==0){
        Console.WriteLine("You both have same name");
    }
    else if(name.CompareTo(friendName)<0){
        Console.WriteLine("Your name comes first in the dictionary");
    }

    else if(name.CompareTo(friendName)>0){
        Console.WriteLine("Your friend's name comes first in the dictionary");
    }

    else{
        Console.WriteLine("You both have different name");
    }


  


        


    }
}