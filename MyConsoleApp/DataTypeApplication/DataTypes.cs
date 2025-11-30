using System;

namespace MyConsoleApp.DataTypeApplication;


// 值类型
public class ValueTypes
{
    // bool	    布尔值	True 或 False	False
    // byte	    8位无符号整数	0 到 255	0
    // char	    16位Unicode 字符	U +0000 到 U +ffff	'\0'
    // decimal	128位精确的十进制值，28-29 有效位数	(-7.9 x 1028 到 7.9 x 1028) / 100 到 28	0.0M
    // double	64位双精度浮点型	(+/-)5.0 x 10-324 到 (+/-)1.7 x 10308	0.0D
    // float	32位单精度浮点型	-3.4 x 1038 到 + 3.4 x 1038	0.0F
    // int	    32位有符号整数类型	-2,147,483,648 到 2,147,483,647	0
    // long	    64位有符号整数类型	-9,223,372,036,854,775,808 到 9,223,372,036,854,775,807	0L
    // sbyte	8位有符号整数类型	-128 到 127	0
    // short	16位有符号整数类型	-32,768 到 32,767	0
    // uint	    32位无符号整数类型	0 到 4,294,967,295	0
    // ulong	64位无符号整数类型	0 到 18,446,744,073,709,551,615	0
    // ushort	16位无符号整数类型	0 到 65,535	0

    private bool _bool;      
    private byte _byte;      
    private char _char;      
    private decimal _decimal;
    private double _double;
    private float _float;
    private int _int;
    private long _long;
    private sbyte _sbyte;
    private short _short;
    private uint _uint;
    private ulong _ulong;
    private ushort _ushort;

    public static void Demo()
    {
        Console.WriteLine("\n");
        new ValueTypes().DisplayDefaultValue().DisplayMinMaxValue().SizeOfInt();

    }

    public ValueTypes DisplayDefaultValue()
    {
        Console.WriteLine($"bool type default value: {_bool}");
        Console.WriteLine($"byte type default value: {_byte}");
        Console.WriteLine($"char type default value: {_char}");
        Console.WriteLine($"decimal type default value: {_decimal}");
        Console.WriteLine($"double type default value: {_double}");
        Console.WriteLine($"float type default value: {_float}");
        Console.WriteLine($"int type default value: {_int}");
        Console.WriteLine($"long type default value: {_long}");
        Console.WriteLine($"sbyte type default value: {_sbyte}");
        Console.WriteLine($"short type default value: {_short}");
        Console.WriteLine($"uint type default value: {_uint}");
        Console.WriteLine($"ulong type default value: {_ulong}");
        Console.WriteLine($"ushort type default value: {_ushort}");

        return this;
    }

    public ValueTypes DisplayMinMaxValue()
    {
        Console.WriteLine($"byte:       {byte.MinValue} ~ {byte.MaxValue}\t");
        Console.WriteLine($"char:       {char.MinValue} ~ {char.MaxValue}\t");
        Console.WriteLine($"decimal:    {decimal.MinValue} ~ {decimal.MaxValue}\t");
        Console.WriteLine($"double:     {double.MinValue} ~ {double.MaxValue}\t");
        Console.WriteLine($"float:      {float.MinValue} ~ {float.MaxValue}\t");
        Console.WriteLine($"int:        {int.MinValue} ~ {int.MaxValue}\t");
        Console.WriteLine($"long:       {long.MinValue} ~ {long.MaxValue}\t");
        Console.WriteLine($"sbyte:      {sbyte.MinValue} ~ {sbyte.MaxValue}\t");
        Console.WriteLine($"short:      {short.MinValue} ~ {short.MaxValue}\t");
        Console.WriteLine($"uint:       {uint.MinValue} ~ {uint.MaxValue}\t");
        Console.WriteLine($"ulong:      {ulong.MinValue} ~ {ulong.MaxValue}\t");
        Console.WriteLine($"ushort:     {ushort.MinValue} ~ {ushort.MaxValue}\t");

        return this;
    }

    public ValueTypes SizeOfInt()
    {
        // 获取一个类型或一个变量在特定平台上的准确尺寸
        Console.WriteLine($"Size of Int: {sizeof(int)}");

        return this;
    }
}


// 引用类型
public class ReferenceTypes
{
    // 内置引用类型 object(对象), dynamic(动态), string(字符串);

    private object _obj = 123456;
    
    private String _string1 = "Hello World!";
    private String _string2 = @"C:\Windows";        // 转义字符串 @ 等价于 C:\\Windows

    private String _string3 = @"                    // 可以任意换行, 换行符及缩进空格都计算在字符串长度之内
    Hello World!
    <a href=''>
            </a>
                        N
                    ";   
    
    private dynamic _dynamic1= false;
    private dynamic _dynamic2 = "Hello World!";
    private dynamic _dynamic3 = 11.45;

    public static void Demo()
    {
        Console.WriteLine("\n");
        new ReferenceTypes().DisplayObject().DisplayString().DisplayDynamic();
    }

    public ReferenceTypes DisplayObject()
    {
        Console.WriteLine($"object: {_obj}");

        return this;
    }

    public ReferenceTypes DisplayString()
    {
        Console.WriteLine($"String: {_string1}");
        Console.WriteLine($"转义字符串: {_string2}");
        Console.WriteLine($"换行: {_string3}, Length: {_string3.Length}");

        return this;
    }

    public ReferenceTypes DisplayDynamic()
    {
        Console.WriteLine($"dynamic: {_dynamic1}, type: {_dynamic1.GetType()}, {_dynamic1 is bool}");
        Console.WriteLine($"dynamic: {_dynamic2}, type: {_dynamic2.GetType()}, {_dynamic2 is string}");
        Console.WriteLine($"dynamic: {_dynamic3}, type: {_dynamic3.GetType()},  {_dynamic3 is string}");
        
        return this;
    }
}


// 指针类型
public class PointerTypes
{
    private int a = 10; 
    // int* b = a;
    
    public static void Demo()
    {
        new PointerTypes().DisplayPointer();
    }

    public PointerTypes DisplayPointer()
    {
        Console.WriteLine($"a: {a}");

        return this;
    }
}

public class ExecuteDataType
{
    public static void Run()
    {
        ValueTypes.Demo();
        ReferenceTypes.Demo();
        PointerTypes.Demo();
    }
}