using System;

namespace MyConsoleApp.ClassApplication;

public abstract class Test
{
    public Test()
    {
        Print();
    }
    
    public abstract void Print();
}

// 多态是同一个行为具有多个不同表现形式或形态的能力
public class Polymorphism : Test
{
    // 函数重载
    public int Add(int a, int b) => a + b;
    
    public int Add(int a, int b, int c)  => a + b + c;
    
    public double Add(double a, double b) => a + b;
    
    public long Add(long a, long b) => a + b;
    
    public float Add(float a, float b) => a + b;

    public override void Print()
    {
        Console.WriteLine("Override Abstract Function");
    }

    public static void Demo()
    {
        new Polymorphism();
    }
}


public class ExecutePolymorphism
{
    public static void Run()
    {
        Polymorphism.Demo();
    }
}