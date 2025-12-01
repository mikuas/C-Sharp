using System;

namespace MyConsoleApp.EnumApplication;

// 枚举
enum Day
{
    Sun,
    Mon,
    Tue,
    Wed,
    Thu,
    Fri,
    Sat
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