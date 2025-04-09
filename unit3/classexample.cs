// public class Vechile{
//     string name,model;
//     int year;

//     void speed(){
//         Console.WriteLine("Hello Speed");
//     }
//     void brake(){
//     Console.WriteLine("Hello Break");
//     }
// }




// Create a simple class named Person that contains basic information like name ,age,gender,etc your class shoould also contain function/method for storing and displaying data
using System;

class Person {
    string name, gender;
    int age;

    public void setData(string name, string gender, int age) {
        this.name = name;
        this.gender = gender;
        this.age = age;
    }

    public void display() {
        Console.WriteLine("Your name is "+name+", age is"+age+", and gender is"+gender);
    }

    static void Main(string[] args) {
        Person p = new Person();
        p.setData("arun", "male", 23);
        p.display();
    }
}


