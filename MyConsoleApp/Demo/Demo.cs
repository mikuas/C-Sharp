using System;

namespace MyConsoleApp.Demo;


abstract class Father
{

    public Father(string name, string gender, int age)
    {
        Name = name;
        Gender = gender;
        Age = age;
    }

    public Father() {}
    
    public abstract void SayHi();

    public string Name { get; set; } = "Father";
    public string Gender { get; set; } = "Man";
    public int Age { get; set; } = 45;
}


class A : Father
{

    public A()
    {
        Name = "A";
        Gender = "Man";
        Age = 24;
    }
    
    public override void SayHi()
    {
        Console.WriteLine("Hello Im is A!");
    }
}


class B : Father
{
    public B()
    {
        Name = "B";
        Gender = "Not Man";
        Age = 18;
    }
    
    public override void SayHi()
    {
        Console.WriteLine("Hello Im is B!");
    }
}
