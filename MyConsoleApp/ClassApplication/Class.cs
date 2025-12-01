using System;

namespace MyConsoleApp.ClassApplication;


// 定义一个类, 类的默认访问标识符是 internal
public class Class
{
    // 定义成员变量
    public double Length;
    // 默认成员变量标识符是 private
    double _height;
    // 静态成员
    public int Count;

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

    public int GetCount() => Count;
    
    public static void Demo()
    {
        Class obj1 = new Class();
        Class obj2 = new Class(10, 24);
    }
}


public class ExecuteClass
{
    public static void Run()
    {
        Class.Demo();
    }
}