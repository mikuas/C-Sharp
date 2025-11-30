using System;
using System.Linq;
namespace MyConsoleApp.ArrayApplication;

public class Array
{
    public Array StatementArray()
    {
        // 声明数组
        // dataType[] name
        int[] intList;
        double[] doubleList;
        
        // 初始化数组
        intList = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        doubleList = new double[10];

        for (int i = 1; i <= 10; i++)
        {
            doubleList[i - 1] = i;
        }

        // 遍历数组
        foreach (double val in doubleList)
        {
            Console.WriteLine($"Index: {val - 1}, Value: {val}");
        }

        return this;
    }
        
    /// <summary>
    /// 二维及多维数组
    /// </summary>
    /// <returns></returns>
    public Array StatementMultidimensionalArray()
    {
        // 声明二维数组
        int[,] a = new int[,]
        {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 }
        };

        // 声明三维数组
        int[,,] b;
        int[,,,] c = new int[5, 5, 5, 5];
        // 初始化数组
        b = new int[3, 3, 3]
        {
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            },
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            },
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            }
        };

        Console.WriteLine();
        // 遍历二维数组
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write($"[{i},{j}] = {a[i, j]} ");
            }
            Console.WriteLine();
        }

        foreach (int i in a)
        {
            Console.Write($"{i} ");
        }

        // 遍历三维数组
        Console.WriteLine('\n');
        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                for (int m = 0; m < b.GetLength(2); m++)
                {
                    Console.Write($"[{i},{j},{m}] = {b[i, j, m]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 初始化四维数组
        Console.WriteLine();
        int val = 0;
        for (int o = 0; o < c.GetLength(0); o++)
        {
            for (int t = 0; t < c.GetLength(1); t++)
            {
                for (int s = 0; s < c.GetLength(2); s++)
                {
                    for (int f = 0; f < c.GetLength(3); f++, val++)
                    {
                        c[o, t, s, f] = val;
                        Console.Write($"[{o},{t},{s},{f}] = {val} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        return this;
    }

    /// <summary>
    /// 交错数组
    /// </summary>
    /// <returns></returns>
    public Array StatementInterleavedArrays()
    {
        // 声明交错数组
        int[][] arr = new int[3][];
        // 初始化交错数组
        Console.WriteLine();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new int[(i + 1) * (i + 1)];
            for (int j = 0; j < arr[i].Length; j++)
            {
                int val = (i + 1) * (j + 1);
                arr[i][j] = val;
                Console.Write($"[{i},{j}] = {val} ");
            }
            Console.WriteLine();
        }
        return this;
    }

    public double GetAverage(int[]? arr)
    {
        if (arr == null || arr.Length == 0)
        {
            return 0;
        }
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum / arr.Length;
    }

    /// <summary>
    /// 参数数组, 使用params关键字
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public int AddElements(params int[] arr)
    {
        int sum = 0;
        foreach (int value in arr)
        {
            sum += value;
        }
        return sum;
    }
    
    public double AddElements(params double[] arr)
    {
        double sum = 0;
        foreach (double value in arr)
        {
            sum += value;
        }

        return sum;
    }

    public void Test()
    {
        int[] array = {1, 2,  3, 4, 5, 6, 7, 8, 9, 10};
        
        Console.Write("\n数组元素: ");
        PrintArrayElements(array);

        // 获取数组中元素的总个数
        int arrayCount = array.Length;

        // 获取数组的维数
        int arrayRank = array.Rank;

        // 判断数组的大小是否固定
        bool arrayIsFixedSize = array.IsFixedSize;

        // 判断数组是否为只读
        bool arrayIsReadOnly = array.IsReadOnly;

        // 判断数组是否线程安全
        bool arrayIsSynchronized = array.IsSynchronized;

        // 获取用于同步数组访问的对象，通常用于多线程操作
        object arraySyncRoot = array.SyncRoot;
        Console.Write(
            $"\n个数: {arrayCount}, 维度: {arrayRank}, 大小是否固定: {arrayIsFixedSize}, " +
            $"只读: {arrayIsReadOnly}, 线程是否安全: {arrayIsSynchronized}, Object: {arraySyncRoot}"
            );

        Console.Write("\n反转数组, 结果: ");
        System.Array.Reverse(array);
        PrintArrayElements(array);
        
        Console.Write("\n对数组进行排序, 结果: ");
        System.Array.Sort(array);
        PrintArrayElements(array);
        
        Console.WriteLine("\n改变数组大小");
        Console.WriteLine($"OldLength: {array.Length}");
        
        System.Array.Resize(ref array, array.Length * 2);
        Console.WriteLine($"NewLength: {array.Length}");
    }

    public void PrintArrayElements(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write($"{item} ");
        }
    }

    public static void Demo()
    {
        int[] arr = new[] {100, 114, 514, 191, 810};
        double avg = new Array().StatementArray().StatementMultidimensionalArray().StatementInterleavedArrays()
            .GetAverage(arr);
        Console.WriteLine($"\naverage: {avg}");
        
        Console.WriteLine(new Array().AddElements(55, 45, 50, 50, 25, 25));
        Console.WriteLine(new Array().AddElements(11.4, 51.4, 1.91, 8.10).ToString("F2"));

        Array a = new Array();
        a.Test();
    }
}


public class ExecuteArray
{
    public static void Run()
    {
        Array.Demo();
    }
}