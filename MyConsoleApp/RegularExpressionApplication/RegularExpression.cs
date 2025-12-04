using System;
using System.Text.RegularExpressions;

namespace MyConsoleApp.RegularExpressionApplication;

public class RegularExpression
{
    public static void Demo()
    {
        Console.WriteLine("\a");
        Console.WriteLine("\b");
        
        Console.WriteLine("------");
        Console.WriteLine("Hello\rWorld!");
        
        Console.WriteLine(Regex.IsMatch("123", @"^\d+$")); // 匹配数字, 需全部都是数字
        Console.WriteLine(Regex.IsMatch("I234", @"^\d+$"));
        
        Console.WriteLine(Regex.IsMatch("123==45", @"\d+"));    // 出现数字就算匹配成功
        
        Console.WriteLine(Regex.IsMatch("HelloWorld", @"^[a-zA-z]+$")); // 匹配字母
        
        Console.WriteLine(Regex.Match("ab114514CDE1919810", @"\d+").Value);    // 提取数字
        
        Console.WriteLine(Regex.IsMatch("Hello World", @"^H\S.*d$"));
    }
}


public class ExecuteRegularExpression
{
    public static void Run()
    {
        RegularExpression.Demo();
    }
}