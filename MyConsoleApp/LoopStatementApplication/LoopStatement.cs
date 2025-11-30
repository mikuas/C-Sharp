using System;

namespace MyConsoleApp.LoopStatementApplication;

public class LoopStatement
{

    public LoopStatement WhileLoopStatement()
    {
        int a = 100;
        while (a > 0)
        {
            Console.Write($"{a} ");
            a--;
        }

        return this;
    }

    public LoopStatement ForLoopStatement()
    {
        Console.WriteLine();
        for (int a = 1; a <= 100; a++)
        {
            Console.Write($"{a} ");
        }
        Console.WriteLine();

        return this;
    }

    public LoopStatement ForEachLoopStatement()
    {
        int[] list = new int[24];

        for (int i = 1; i <= 24; i++)
        {
            list[i - 1] = i;
        }

        foreach (int num in list)
        {
            Console.WriteLine($"Index: {Array.IndexOf(list, num)}, Value: {num}");
        }

        return this;
    }

    public LoopStatement DoWhileLoopStatement()
    {
        // do while循环至少执行一次, 先执行再判断
        int a = 10;
        do
        {
            Console.WriteLine(a);

        } while (a != 10);

        return this;
    }
    
    public static void Demo()
    {
        new LoopStatement().WhileLoopStatement().ForLoopStatement().ForEachLoopStatement().DoWhileLoopStatement();
    }
}


public class ExecuteLoopStatement
{
    public static void Run()
    {
        LoopStatement.Demo();
    }
}