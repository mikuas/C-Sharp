using System;

namespace MyConsoleApp.OperatorApplication;

public class BitOperators
{
    public static void Demo()
    {
        int a = 0;
        int b = 1;

        Console.WriteLine("\n&运算符, 不会短路, a为false, b还会执行");
        Console.WriteLine($"{a} & {b} = {a & b}");
        Console.WriteLine($"{b} & {a} = {b & a}");
        Console.WriteLine($"{a} & {a} = {a & a}");
        Console.WriteLine($"{b} & {b} = {b & b}");
        
        Console.WriteLine("\n|运算符");
        Console.WriteLine($"{a} | {b} = {a | b}");
        Console.WriteLine($"{b} | {a} = {b | a}");
        Console.WriteLine($"{a} | {a} = {a | a}");
        Console.WriteLine($"{b} | {b} = {b | b}");
        
        Console.WriteLine("\n^运算符, 相同为0(false), 不同为1{true)");
        Console.WriteLine($"{a} ^ {b} = {a ^ b}");
        Console.WriteLine($"{b} ^ {a} = {b ^ a}");
        Console.WriteLine($"{a} ^ {a} = {a ^ a}");
        Console.WriteLine($"{b} ^ {b} = {b ^ b}");
        Console.WriteLine($"false ^ false = {false ^ false}");
        Console.WriteLine($"true ^ false = {true ^ false}");
        Console.WriteLine($"true ^ true = {true ^ true}");

        a = 0b00111100; // 0011 1100
        b = 0b00001101; // 0000 1101
        Console.WriteLine("\n~运算符, 按位取反");
        Console.WriteLine($"~{Convert.ToString(a, 2)} = {Convert.ToString((~a), 2)}");
        Console.WriteLine($"~{Convert.ToString(b, 2)} = {Convert.ToString((~b), 2)}");
        
        Console.WriteLine("\n<<运算符, 左移运算符");
        Console.WriteLine($"{Convert.ToString(a, 2)} << 2 = {Convert.ToString(a << 2, 2)}");
        Console.WriteLine($"{Convert.ToString(b, 2)} << 2 = {Convert.ToString(b << 2, 2)}");
        
        Console.WriteLine("\n>>运算符, 右移运算符");
        Console.WriteLine($"{Convert.ToString(a, 2)} >> 2 = {Convert.ToString(a >> 2, 2)}");
        Console.WriteLine($"{Convert.ToString(b, 2)} >> 2 = {Convert.ToString(b >> 2, 2)}");
    }
}


public class ExecuteBitOperator
{
    public static void Run()
    {
        BitOperators.Demo();
    }
}