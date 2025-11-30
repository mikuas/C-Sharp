using System;
namespace MyConsoleApp.VariableApplication;

public class Variable
{
    // 初始化变量
    private int a;
    private int b = 10;

    // 初始化多个变量
    private int c, d, e;
    private int f = 1, g = 2;

    public Variable ReadLine()
    {
        Console.WriteLine("请输入:\n");
        int number;
        dynamic input = Console.ReadLine();
        Console.WriteLine(input, input.GetType());

        return this;
    }

    public static void Demo()
    {
        new Variable().ReadLine();
    }
}


public class ExecuteVariable
{
    public static void Run()
    {
        Variable.Demo();
    }
}