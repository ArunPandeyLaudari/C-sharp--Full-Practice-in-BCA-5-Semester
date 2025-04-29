using System.Collections.Generic;

class Test<T>
{
    T[] t = new T[5];

    int count=0;

    public void addition(T item){
        if(count<5){
            {
                t[count]=item;
                count++;
            }
        }
        else{
            Console.WriteLine("OverFlow Exits");
        }
    }

    public void display(){
        for(int i=0;i<count;i++){
            Console.WriteLine("Index at " + i + " is :" + t[i]);
        }
    }
}

class Program{
    static void Main(){
        Test<int> obj =new Test<int> ();
        obj.addition(10);
        obj.addition(20);
        obj.addition(30);
        obj.addition(40);
        obj.addition(50);
        obj.addition(60);
        obj.addition(70);
        obj.display();
    }
}