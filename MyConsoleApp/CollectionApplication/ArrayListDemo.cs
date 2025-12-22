using System;
using System.Collections;


namespace MyConsoleApp.CollectionApplication;

public class ArrayListDemo
{
    // 动态数组
    public static void Demo()
    {
        ArrayList array = new ArrayList();
        
        // 添加元素
        array.Add(1);
        // 将指定集合的元素添加到array的末尾
        ArrayList tmp = new ArrayList();
        tmp.Add(2);
        tmp.Add(3);
        tmp.Add(4);
        tmp.Add(5);
        
        array.AddRange(tmp);
        // 在指定索引处插入对象
        array.Insert(0, "Hello World!");
        // 在指定索引处插入指定集合的元素
        tmp = new ArrayList();
        tmp.Add("Hello C#");
        tmp.Add("Hello ArrayList");
        array.InsertRange(1, tmp);
        
        // 移除首次出现的对象
        array.Add(5);
        array.Add(5);
        array.Remove(5);
        // 移除指定索引处的元素
        Console.WriteLine("Remove -1\n");
        array.RemoveAt(array.Count - 1);
        Print(array);
        
        // 移除指定索引处开始的指定数量的元素
        Console.WriteLine("Remove Range 3-5\n");
        array.RemoveRange(3, 5);
        Print(array);
        
        // 获取元素数量
        Console.WriteLine($"array Count: {array.Count}");
        // 获取或设置ArrayList的容量
        Console.WriteLine($"array 容量: {array.Capacity}");
        // 是否具有固定大小
        Console.WriteLine($"Is Fixed Size: {array.IsFixedSize}");
        // 是否为自读
        Console.WriteLine($"Is ReadOnly: {array.IsReadOnly}");
        // 是否线程安全
        Console.WriteLine($"Is Synchronized: {array.IsSynchronized}");
        // 获取可用于同步访问的对象
        Console.WriteLine($"Sync Root: {array.SyncRoot}");
        
        Console.WriteLine();
        Print(array);
        Console.WriteLine($"array 包含 Hello World: {array.Contains("Hello World")}");
        Console.WriteLine($"array 包含 Hello World!: {array.Contains("Hello World!")}");
        
        // 获取指定对象首次出现的索引
        Console.WriteLine($"Hello C# 首次出现的索引: {array.IndexOf("Hello C#")}");
        
        // 获取最后一次出现的索引
        Console.WriteLine($"Hello C# 最后一次出现的索引: {array.LastIndexOf("Hello C#")}");
        
        // 排序与复制
        array.Sort(); // 按照默认排序ArrayList中的元素
        Console.WriteLine("\nSort Array");
        Print(array);
        
        // 使用自定义排序
        array.Sort(new CustomComparer());
        Console.WriteLine("\nCustom Sort Array(Length)");
        Print(array);
        
        // 反转元素 
        array.Reverse();
        Console.WriteLine("\nReverse Array");
        Print(array);
        
        // 复制
        // 将ArrayList的元素复制到指定数组中
        string[] result = new string[1];
        // array.CopyTo(result);
        array.CopyTo(1, result, 0, 1);
        Console.WriteLine("\nCopy To result, Index 1, result Index 0, Count 1");
        Print(result);
        
        // 获取从指定索引开始的指定数量的元素子集
        Console.WriteLine();
        for (int i = 0; i < 6; i++)
        {
            array.Add(i);
        }
        Print(array);
        Console.WriteLine("获取从Index 4 开始的 5 个元素");
        Print(array.GetRange(4, 5));
        
        // 将ArrayList的元素复制到数组中
        Console.WriteLine();
        var a = array.ToArray();
        Print(a);
        
        // 将容量调整为实际元素数量以节省内存
        Console.WriteLine("调整容量");
        Console.WriteLine($"Old Size: {array.Capacity}");
        array.TrimToSize();
        Console.WriteLine($"New Size: {array.Capacity}");

        // 清空所有元素
        Console.WriteLine("Clear All Item\n");
        array.Clear();
        Print(array);
    }

    private static void Print(IEnumerable list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    public class CustomComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is null || y is null)
            {
                return 0;
            }
            return ((string)x).Length.CompareTo(((string)y).Length);
        }
    }
}


public class ExecuteArrayListDemo
{
    public static void Run()
    {
        ArrayListDemo.Demo();
    }
}