using System;

namespace MyConsoleApp.DataTypeApplication;

// C# 中的类型转换可以分为两种：隐式类型转换和显式类型转换（也称为强制类型转换）
public class TypeConversion
{
    public int Height { get; set; }
    
    public TypeConversion() {}
    
    public TypeConversion(int height)
    {
        Height = height;
    }
    
    /// <summary>
    /// 隐式转换
    /// </summary>
    public TypeConversion ImplicitConversion()
    {
        Console.WriteLine("\n隐式转换");
        byte byteValue = 10;
        int intResult = byteValue;
        Console.WriteLine($"byte to int: byte, {byteValue}, int: {intResult}");


        int intValue = 114;
        long longResult = intValue;
        Console.WriteLine($"int to long: int, {intValue}, long: {longResult}");

        float floatValue = 11.4514f;
        double doubleResult = floatValue;
        Console.WriteLine($"float to double, float: {floatValue}, double: {doubleResult}");

        return this;
    }

    /// <summary>
    /// 显示转换
    /// </summary>
    public TypeConversion ExplicitConversions()
    {   
        Console.WriteLine("\n显示转换");
        float floatValue = 11.4514f;
        double doubleValue = 11.45141919810;

        int intResult = (int)floatValue;
        Console.WriteLine($"float to int, float: {floatValue}, int: {intResult}");
        
        intResult = (int)doubleValue;
        Console.WriteLine($"double to int, float: {doubleValue}, int: {intResult}");

        string stringResult = intResult.ToString();
        Console.WriteLine($"int to string, int: {intResult}, string: {stringResult}");

        string stringValue = "123456";
        intResult = Convert.ToInt32(stringValue);
        Console.WriteLine($"string to int, string: {stringValue}, int: {intResult}");
        
        Console.WriteLine(Convert.ToInt32(double.Parse("123.456")));
        
        return this;
    }

    /// <summary>
    /// 自定义显示转换 explicit
    /// </summary>
    public static explicit operator TypeConversion(int h)
    {
        return new TypeConversion(h);
    }

    /// <summary>
    /// 隐式转换 implicit
    /// </summary>
    public static implicit operator int(TypeConversion t)
    {
        return t.Height;
    }

    /// <summary>
    /// TryParse解析, 成功返回true
    /// </summary>
    public TypeConversion TryParseDemo()
    {
        Console.WriteLine("\nTryParse解析");
        string str1 = "";
        string str2 = "0";
        string str3 = "1";
        string str4 = "True";
        string str5 = "False";
        bool result;
        Console.WriteLine($"''解析为bool: {Boolean.TryParse(str1, out result)}, 结果: {result}");
        Console.WriteLine($"'0'解析为bool: {Boolean.TryParse(str2, out result)}, 结果: {result}");
        Console.WriteLine($"'1'解析为bool: {Boolean.TryParse(str3, out result)}, 结果: {result}");
        Console.WriteLine($"'True'解析为bool: {Boolean.TryParse(str4, out result)}, 结果: {result}");
        Console.WriteLine($"'False'解析为bool: {Boolean.TryParse(str5, out result)}, 结果: {result}");

        return this;
    }

    public static void Run()
    {
        TypeConversion t = new TypeConversion().ImplicitConversion().ExplicitConversions().TryParseDemo();

        int a = 10;
        Console.WriteLine((TypeConversion)a);
        Console.WriteLine(t.Height);
    }
}


public class ExecuteTypeConversion
{
    public static void Run()
    {
        TypeConversion.Run();
    }
}