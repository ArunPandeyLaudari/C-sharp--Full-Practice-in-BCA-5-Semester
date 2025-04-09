using System;

class Student{
    public int id,age;
    public string name,subject;


    public Student(int id,string name,int age,string subject){
        this.id=id;
        this.name=name;
        this.age=age;
        this.subject;
    }

    public void showInfo(){
        Console.WriteLine(id+" "+name+" "+age+" "+subject);
    }

    public static void main(string[] args){
    
    Student s=new Student(1,"Arun",21,'Math');
    s.showInfo();
    }
}