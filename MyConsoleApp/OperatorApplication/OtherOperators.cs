using System;
using System.IO;

namespace MyConsoleApp.OperatorApplication;

public class OtherOperators
{
    public OtherOperators SizeOfOperators()
    {
        Console.WriteLine(sizeof(int));
        Console.WriteLine(sizeof(double));
        Console.WriteLine(sizeof(float));
        Console.WriteLine(sizeof(bool));

        return this;
    }

    public OtherOperators TypeOfOperators()
    {
        Console.WriteLine(typeof(OtherOperators));
        return this;
    }

    public unsafe OtherOperators PrintAddress()
    {
        int value = 114514;
        int* ptr = &value;

        Console.WriteLine($"Address: {(long)ptr:X}");
        return this;
    }
    
    public static void Demo()
    {
        new OtherOperators().SizeOfOperators().TypeOfOperators().PrintAddress();
        
        Console.WriteLine("\n条件表达式");
        Console.WriteLine(1 / 2 > 2 / 5 ? true : false);
        Console.WriteLine("\nis, 判断对象是否为某一类型");
        Console.WriteLine(new OtherOperators() is ExecuteOtherOperators);
        
        Console.WriteLine("\nas, 强制转换,失败也不会抛出异常");
        object obj = new StringReader("hello world");
        StringReader str = obj as StringReader;
        Console.WriteLine(str);
    }
}


public class ExecuteOtherOperators
{
    public static void Run()
    {
        OtherOperators.Demo();
    }
}