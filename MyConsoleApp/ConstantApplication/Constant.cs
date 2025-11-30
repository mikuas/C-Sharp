using System;

namespace MyConsoleApp.ConstantApplication;

public class Constant
{
    // 常量
    public const int lenght = 24;

    public int Width { get; set; } = 1;
    public int Height { get; set; } = 1;
    
    public int GetVolume() => Width * Height * lenght;

    public static void Demo()
    {
        Console.WriteLine(new Constant().GetVolume());
    }
}


public class ExecuteConstant
{
    public static void Run()
    {
        Constant.Demo();
    }
}