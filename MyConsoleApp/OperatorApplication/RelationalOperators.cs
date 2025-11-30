using System;

namespace MyConsoleApp.OperatorApplication;

public class RelationalOperators
{
    
    /// <summary>
    /// 等于运算
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public RelationalOperators EqualsOperators(object a, object b)
    {
        Console.WriteLine($"\n{a} == {b}: {a == b}");
        return this;
    }

    /// <summary>
    /// 不等于运算
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public RelationalOperators NotEqualsOperators(object a, object b)
    {
        Console.WriteLine($"{a} != {b}: {a != b}");
        return this;
    }

    /// <summary>
    /// 大于运算
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public RelationalOperators GreaterThan(int a, int b)
    {
        Console.WriteLine($"{a} > {b}: {a > b}");
        return this;
    }

    /// <summary>
    /// 小于运算
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public RelationalOperators LessThan(int a, int b)
    {
        Console.WriteLine($"{a} < {b}: {a < b}");
        return this;
    }
    
    /// <summary>
    /// 大于等于运算
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public RelationalOperators GreaterThanOrEqual(int a, int b)
    {
        Console.WriteLine($"{a} >= {b}: {a >= b}");
        return this;
    }

    /// <summary>
    /// 小于等于运算
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public RelationalOperators LessThanOrEqual(int  a, int b)
    {
        Console.WriteLine($"{a} <= {b}: {a <= b}");
        return this;
    }

    public static void Demo()
    {
        new RelationalOperators()
            .EqualsOperators(1, "1").EqualsOperators(0, 0).EqualsOperators(false, false).EqualsOperators("1", "1")
            .NotEqualsOperators(1, 1).NotEqualsOperators("1", "0").NotEqualsOperators(false, false)
            .GreaterThan(5, 5).GreaterThan(5, 6).GreaterThan(6, 5)
            .LessThan(5,  5).LessThan(5, 6).LessThan(6, 5)
            .GreaterThanOrEqual(5, 5).GreaterThanOrEqual(5, 6).GreaterThanOrEqual(6, 5)
            .LessThanOrEqual(5, 4).LessThanOrEqual(5, 6);
    }
}


public class ExecuteRelationalOperators
{
    public static void Run()
    {
        RelationalOperators.Demo();
    }
}