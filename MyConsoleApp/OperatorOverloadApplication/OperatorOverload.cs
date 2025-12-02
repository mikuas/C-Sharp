using System;

namespace MyConsoleApp.OperatorOverloadApplication;

public class Box
{
    public double Length;
    public double Width;
    public double Height;

    public Box() {}

    public Box(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public double GetArea() => Length * Width;
    
    public double GetVolume() => Length * Width * Height;
    
    /*
     * +, -, !, ~, ++, --                           这些一元运算符只有一个操作数，且可以被重载
     * +, -, *, /, %                                这些二元运算符带有两个操作数，且可以被重载
     * ==, !=, <, >, <=, >=                         这些比较运算符可以被重载
     * &&, ||                                       这些条件逻辑运算符不能被直接重载
     * +=, -=, *=, /=, %=                           这些赋值运算符不能被重载
     * =, ., ?:, ->, new, is, sizeof, typeof        这些运算符不能被重载
     */
    
    // 重载 + 运算符来把两个 Box 对香港相加
    public static Box operator +(Box a, Box b)
    {
        return new Box(a.Length + b.Length, a.Width + b.Width, a.Height + b.Height);
    }

    public static Box operator -(Box a, Box b)
    {
        return new Box(a.Length - b.Length, a.Width - b.Width, a.Height - b.Height);
    }

    public static bool operator ==(Box a, Box b)
    {
        return a.GetArea() == b.GetArea() && a.GetVolume() == b.GetVolume();
    }

    public static bool operator !=(Box a, Box b)
    {
        return !(a == b);
    }
}


public class OperatorOverload
{
    public static void Demo()
    {
        Box b1 = new Box(3, 4, 5);
        Box b2 = new Box(6, 7, 8);
        
        Console.WriteLine($"b1 area: {b1.GetArea()}, b1 volume: {b1.GetVolume()}");
        Console.WriteLine($"b2 area: {b2.GetArea()}, b2 volume: {b2.GetVolume()}");
        
        Console.WriteLine($"b1 + b2 area: {(b1 + b2).GetArea()},  b1 + b2 volume: {(b1 + b2).GetVolume()}");
        Console.WriteLine($"b1 - b2 area: {(b1 - b2).GetArea()},  b1 - b2 volume: {(b1 - b2).GetVolume()}");
        Console.WriteLine($"b1 == b2: {b1 == b2}");
        Console.WriteLine($"b1 != b2: {b1 != b2}");
    }
}


public class ExecuteOperatorOverload
{
    public static void Run()
    {
        OperatorOverload.Demo();
    }
}