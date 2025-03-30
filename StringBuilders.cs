using System;

using System.Text;
class Program{
    static void Main(){
        StringBuilder builder=new StringBuilder();
        for(int i=0;i<=10;i++){
            builder.Append(i).Append("");
        }
        Console.WriteLine(builder);
    }
}