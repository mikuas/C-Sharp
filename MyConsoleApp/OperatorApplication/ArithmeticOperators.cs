using System;

namespace MyConsoleApp.OperatorApplication;

public class ArithmeticOperators
{
    
    /// <summary>
    /// 加法运算符
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public ArithmeticOperators AddOperators(double a, double b)
    {
        Console.WriteLine($"\n{a} + {b} = {a + b}");
        return this;
    }
    
    /// <summary>
    /// 减法运算符
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public ArithmeticOperators SubtractionOperator(double a, double b)
    {
        Console.WriteLine($"\n{a} - {b} = {a - b}");
        return this;
    }

    /// <summary>
    /// 乘法运算符
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public ArithmeticOperators MultiplicationOperator(int a, int b)
    {
        Console.WriteLine($"\n{a} * {b} = {a * b}");
        return this;
    }

    public ArithmeticOperators DivisionOperator(int a, int b)
    {
        if (b != 0) Console.WriteLine($"\n{a} / {b} = {a / b}");
        return this;
    }

    public ArithmeticOperators ModulusOperator(int a, int b)
    {
        if (b != 0) Console.WriteLine($"\n{a} % {b} = {a % b}");
        return this;
    }

    public ArithmeticOperators SelfAddedCalculations(int a)
    {
        Console.WriteLine($"\na default value: {a}");
        Console.WriteLine($"++a: {++a} 先加再运算");
        Console.WriteLine($"a++: {a++} 运算了在加");
        Console.WriteLine($"result: {a}");
        return this;
    }

    public ArithmeticOperators SelfSubtractionCalculations(int a)
    {
        Console.WriteLine($"\na default value: {a}");
        Console.WriteLine($"--a: {--a} 先减再运算");
        Console.WriteLine($"a--: {a--} 运算了在减");
        Console.WriteLine($"result: {a}");
        return this;
    }

    public static void Demo()
    {
        new ArithmeticOperators().AddOperators(5, 5).SubtractionOperator(10, 24).MultiplicationOperator(10, 2)
            .DivisionOperator(2, 1).DivisionOperator(3, 0).ModulusOperator(25, 24).ModulusOperator(10, 20)
            .SelfAddedCalculations(5).SelfSubtractionCalculations(5);
    }
}


public class ExecuteArithmeticOperators
{
    public static void Run()
    {
        ArithmeticOperators.Demo();
    }
}