using System;
namespace MyConsoleApp.NullableTypeApplication;

public class NullableType
{
    public static void Demo()
    {
        // 可空类型的声明语法
        // <data_type>? <variable_name> = null;
        
        // int i = null; 
        // 可空类型
        int? i = null;
        double? num = new double?();
        Nullable<int> x = null;
        Nullable<bool> flag = null;
        
        // Null合并运算符(??) 当左侧的值为null时 ??返回右侧的默认值。
        int result = i ?? 5;

        bool isHasValue = i.HasValue; //判断变量是否有值
        int defalutValue = i.GetValueOrDefault(); // 获取默认值
        Console.WriteLine($"result: {result}\ndefaultValue: {defalutValue}\nisHasValue: {isHasValue}");
        
        // new NullableType();
        
    }
}


public class ExecuteNullableType
{
    public static void Run()
    {
        NullableType.Demo();
    }
}