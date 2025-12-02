using System;

namespace MyConsoleApp.ClassApplication;


// 抽象类 abstract
public abstract class Test1
{
    // 抽象类不能被实例化
}

// 密封类 sealed
public sealed class Test2
{
    // 密封类不能被继承
}

// 定义一个类, 类的默认访问标识符是 internal
public class Class
{
    // 定义成员变量
    public double Length;
    // 默认成员变量标识符是 private
    double _height;

    public int Count;
    // 静态成员
    public static int StaticCount;

    // 无参构造函数
    public Class()
    {
        Console.WriteLine("对象已创建");
    }
    ~Class() // 析构函数
    /*
     * 析构函数的名称是在类的名称前加上一个波浪形 (~) 作为前缀 它不返回值,也不带任何参数
     * 析构函数用于在结束程序(比如关闭文件, 释放内存等)之前释放资源, 析构函数不能继承或重载
     */
    {
        Console.WriteLine("对象已删除");
    }
    
    // 有参构造函数
    public Class(double length, double height)
    {
        Console.WriteLine("有参构造函数");
        Length = length;
        _height = height;
    }

    public void Add()
    {
        Count++;
    }

    public void StaticAdd()
    {
        StaticCount++;
    }

    public int GetCount() => Count;

    // static方法只能访问static成员变量
    public static void StaticFunc()
    {
        Console.WriteLine(StaticCount);
    }
    
    public int GetStaticCount() => StaticCount;

    public static void Demo()
    {
        Class obj1 = new Class();
        Class obj2 = new Class(10, 24);

        Class test1 = new Class();
        Class test2 = new Class();
        
        test1.Add();
        test1.Add();
        test1.Add();
        test1.StaticAdd();
        test1.StaticAdd();
        test1.StaticAdd();
        
        test2.Add();
        test2.Add();
        test2.Add();
        test2.Add();
        test2.StaticAdd();
        test2.StaticAdd();
        test2.StaticAdd();
        
        Console.WriteLine($"Count: {test1.GetCount()}, StaticCount: {test1.GetStaticCount()}");
        Console.WriteLine($"Count: {test2.GetCount()}, StaticCount: {test2.GetStaticCount()}");
    }
}


public class ExecuteClass
{
    public static void Run()
    {
        Class.Demo();
    }
}