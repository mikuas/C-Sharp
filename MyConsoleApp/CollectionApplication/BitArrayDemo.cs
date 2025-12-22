using System;
using System.Collections;
using System.Collections.Generic;


namespace MyConsoleApp.CollectionApplication;

public class BitArrayDemo
{
    // 点阵列
    // BitArray 是 C# 中用于表示一组位(bit)值的集合
    public static void Demo()
    {
        BitArray bitArray1 = new BitArray(5 , false);
        BitArray bitArray2 = new BitArray(5 , true);
        
        foreach (var item in bitArray1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        foreach (var item in bitArray2)
        {
            Console.WriteLine(item);
        }
        
        // 获取 BitArray 中的位数
        int count = bitArray1.Count;
        Console.WriteLine($"\nbitArray1 中的位数: {count}");
        
        // 获取或设置BitArray中的位数(支持动态调整大小)
        int length = bitArray1.Length;
        Console.WriteLine($"bitArray1 Length: {length}\n");

        // 获取或设置指定索引处的值
        var i3 = bitArray1[3];
        Console.WriteLine($"bitArray1 Index At 3 Value: {i3}\n");
        
        Console.WriteLine("设置 bitArray1 Index At 3 的值为 True");
        bitArray1[3] = true;
        i3 = bitArray1[3];
        Console.WriteLine($"bitArray1 Index At 3 Value: {i3}");
        
        
        // 按位操作, 将两个 BitArray对应位进行与运算
        Console.WriteLine("\n按位与运算结果:");
        BitArray rb = bitArray1.And(bitArray2);

        foreach (var item in rb)
        {
            Console.WriteLine(item);
        }
        
        // 或运算
        Console.WriteLine("\n或运算结果:");
        rb = bitArray1.Or(bitArray2);
        foreach (var item in rb)
        {
            Console.WriteLine(item);
        }
        
        // 异或运算
        Console.WriteLine("\n异或运算结果(相同为 0，不同为 1):");
        rb = bitArray1.Xor(bitArray2);
        foreach (var item in rb)
        {
            Console.WriteLine(item);
        }
        
        // 按位取反
        Console.WriteLine("\n按位取反结构:");
        rb = bitArray1.Not();
        foreach (var item in rb)
        {
            Console.WriteLine(item);
        }
        
        // 设置指定索引处的值
        bitArray1.Set(0, true);
        
        // 设置所有位设置为指定值
        bitArray1.SetAll(true);
        
        // 获取指定索引处的值
        var i1 = bitArray1.Get(1);
        Console.WriteLine($"bitArray1 Index At 1 Value: {i1}");
        
        // 确定指定对象是否等于当前BitArray
        bool eq = bitArray1.Equals(bitArray2);
        Console.WriteLine($"bitArray 1 == bitArray2: {eq}");
        
        // 获取枚举容器
        Console.WriteLine();
        IEnumerator ie = bitArray1.GetEnumerator();
        while (ie.MoveNext())
        {
            Console.WriteLine(ie.Current);
        }

        BitArrayDemo.Test();
    }

    public static void Test()
    {
        BitArray b1 = new BitArray(new byte[] { 32 });
        BitArray b2 = new BitArray(new byte[] { 255 });
        // 1, 2, 4, 8, 16, 32, 64, 128 ...
        
        Console.WriteLine("\n");
        foreach (bool item in b1)
        {
            Console.Write(item ? 1 : 0);
        }
        Console.WriteLine();
        for (int i = b1.Length - 1; i >= 0; i--)
        {
            Console.Write(b1[i] ? 1 : 0);            
        }
        
        Console.WriteLine();
        for (int i = b2.Length - 1; i >= 0; i--)
        {
            Console.Write(b2[i] ? 1 : 0);
        }
    }
}