using System;

namespace MyConsoleApp.AnonymousMethodApplication;

public class AnonymousMethod
{ 
    delegate void Changed(int v);
    
    public static void Demo()
    {
        // 匿名方法
        // Lambda 表达式是一个简洁的语法, 用于创建匿名函数, 它们通常用于 LINQ 查询和委托
        
        /*
         * 语法
         (parameters) => expression
         (parameters) => { statement; }
         */

        Func<int, int, int> add = (a, b) => a + b;
        Func<int, int, int> max = (a, b) => a > b ? a : b;

        int sum = add(1, 9);
        int mv = max(10, 11);
        
        Console.WriteLine($"Sum: {sum}\nMax: {mv}");
        
        // 使用 delegate 关键字创建委托实例
        var f = delegate(int a, int b) { return a + b; };

        Changed c = x => x++;
        Console.WriteLine(c);
    }
}