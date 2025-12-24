using System;

namespace MyConsoleApp.EnumApplication;

// 枚举
enum Day
{
    Sun = 10,
    Mon,
    Tue,
    Wed,
    Thu,
    Fri,
    Sat,
}


[Flags]
enum AlignFlags
{
    Left = 1 << 0,
    Right = 1 << 1,
    Top = 1 << 2,
    Bottom = 1 << 3,
    
}

public class Enum
{
    public static void Demo()
    {
        Console.WriteLine($"Sum: {(int)Day.Sun}");
        Console.WriteLine($"Sat: {(int)Day.Sat}");
    }
}


public class ExecuteEnum
{
    public static void Run()
    {
        Enum.Demo();
    }
}