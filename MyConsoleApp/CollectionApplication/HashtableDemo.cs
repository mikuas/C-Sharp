using System;
using System.Collections;
using System.Collections.Generic;

namespace MyConsoleApp.CollectionApplication;

public class HashtableDemo
{
    // 键值对形式存储数据的集合
    public static void Demo()
    {
        // 非泛型, 存储object类型
        Hashtable ht = new Hashtable();
        
        // 将指定键值对添加到哈希表
        ht.Add("one", 1);
        ht.Add("two", 2);
        ht.Add("three", 3);
        ht.Add("four", 4);
        ht.Add("five", 5);

        // 获取所有键值
        var keys = ht.Keys;
        // 获取所有值
        var values = ht.Values;
        Print(ht);
        Console.WriteLine($"键值对数量: {ht.Count}"); // 获取键值对数量
        Console.WriteLine($"Keys: {string.Join(", ", keys)}");
        Console.WriteLine($"Values: {string.Join(", ", values)}");

        bool contains = ht.Contains("five");
        Console.WriteLine($"Key 是否包含 five: {contains}");
        
        // 删除指定的键值对
        Console.WriteLine("删除 five 键");
        ht.Remove("five");
        contains = ht.ContainsKey("five");
        Console.WriteLine($"Key 是否包含 five: {contains}");
        
        // 是否包含指定值
        bool cv = ht.ContainsValue(5);
        Console.WriteLine($"Value 是否包含 5: {cv}");
        cv = ht.ContainsValue(2);
        Console.WriteLine($"Value 是否包含 2: {cv}");
        
        // 将哈希表的元素复制到数组, 从指定索引处开始
        object[] result = new object[4];
        DictionaryEntry[] v = new DictionaryEntry[ht.Count];
        
        ht.CopyTo(result, 0);
        ht.CopyTo(v, 0);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        foreach (var item in v)
        {
            Console.WriteLine(item);
        }
        
        // 返回哈希表的枚举器, 用于遍历键值对
        var em = ht.GetEnumerator();
        // 遍历
        while (em.MoveNext())
        {
            var item = em.Current;
            Console.WriteLine($"Current Item: {item}");
        }
        
        // 清空哈希表
        ht.Clear();
    }

    public static void Print(Hashtable h)
    {
        foreach (var key in h.Keys)
        {
            Console.WriteLine($"Key: {key}, Value: {h[key]}");
        }
    }
}


public class DictionaryDemo
{
    public static void Demo()
    {
        // 用法和HastTable一致
        Dictionary<string, string?> dict = new Dictionary<string, string?>();
        
        dict.Add("0001", "zhang_san");
        dict.Add("0002", "li_si");
        dict.Add("0003", "wang_wu");
        dict.Add("0004", "zao_liu");
        dict.Add("0005", "cen_qi");
        dict.Add("0006", null);

        foreach (string key in dict.Keys)
        {
            Console.WriteLine($"Key: {key}, Value: {dict[key] ?? "null"}");
        }
    }
}