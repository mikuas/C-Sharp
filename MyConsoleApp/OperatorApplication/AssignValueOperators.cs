using System;

namespace MyConsoleApp.OperatorApplication;

public class AssignValueOperators
{
    public static void Demo()
    {
        // 赋值运算符
        int a = 10;
        Console.WriteLine(a);
        
        // 加且赋值
        Console.WriteLine($"a += 5 = {a += 5}");
        
        // 减且赋值
        Console.WriteLine($"a -= 5 = {a -= 5}");
        
        // 乘且赋值
        Console.WriteLine($"a *= 5 = {a *= 5}");
        
        // 除且赋值
        Console.WriteLine($"a /= 5 = {a /= 5}");
        
        // 求模且赋值
        Console.WriteLine($"a %= 5 = {a %= 5}");
        
        // 左移且赋值
        Console.WriteLine($"a <<= 2 = {a <<= 2}");
        
        // 右移且赋值
        Console.WriteLine($"a >>= 1 = {a >>= 1}");
        
        // 按位且赋值
        Console.WriteLine($" a &= 2 = {a &= 2}");
        
        // 按位异且赋值
        Console.WriteLine($"a ^= 2 = {a ^= 2}");
        
        // 按位且赋值
        Console.WriteLine($"a |= 2 = {a |= 2}");
    }
}


public class ExecuteAssignValueOperator
{
    public static void Run()
    {
        AssignValueOperators.Demo();
    }
}