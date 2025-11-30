using System;
namespace MyConsoleApp.MethodApplication;

public class Method
{
    // 声明方法
    /*
     * <Access Specifier> <Return Type> <Method Name>(Parameter List)
     * {
     *    Method Body
     * }
     */

    public static void Demo()
    {
        int a = 10;
        int b = 20;
        NumberTool m = new NumberTool();
        
        // 调用方法
        Console.WriteLine($"oldValue: a = {a}, b = {b}");
        m.Swap(ref a, ref b);
        Console.WriteLine($"newValue: a = {a}, b = {b}");
    }
}


public class NumberTool
{
    /// <summary>
    /// 声明方法
    /// </summary>
    /// <param name="a">参数</param>
    /// <param name="b">参数</param>
    public void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}


public class ExecuteMethod {
    public static void Run()
    {
        Method.Demo();
    }
}