using System;

namespace MyConsoleApp.DelegateApplication;

public class Delegate
{
    // 委托

    /*
        委托是一个引用类型, 它定义了一个方法签名, 可以用于存储指向该签名的方法 通过委托 你可以调用其他类中的方法
        委托声明决定了可由该委托引用的方法 委托可指向一个与其具有相同标签的方法
        声明委托的语法如下
        */
    
    // public delegate 返回类型 委托名(参数类型 参数名, ...);
    public delegate int NumberChanged(int x);

    public static int number = 10;

    public static int AddNumber(int x)
    {
        number += x;
        return number;
    }

    public static int MultNumber(int x)
    {
        number *= x;
        return number;
    }

    public static int GetNumber() => number;

    public static void Demo()
    {
        // 创建委托实例
        NumberChanged n1 = new NumberChanged(AddNumber);
        NumberChanged n2 = new NumberChanged(MultNumber);

        // 使用委托调用方法
        Console.WriteLine($"初始值: {GetNumber()}");
        n1(20);
        Console.WriteLine($"AddNumber 20 后的值: {GetNumber()}");
        n2(5);
        Console.WriteLine($"MultNumber 5 后的值: {GetNumber()}");

        // 委托的多播 Multicasting of a Delegate
        // 委托对象可使用 + 运算符进行合并
        // 一个合并委托调用它所合并的两个委托, 只有相同类型的委托可被合并
        // - 运算符可用于从合并的委托中移除组件委托

        
    }
}


public class ExecuteDelegate
{
    public static void Run()
    {
        Delegate.Demo();
    }
}