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
        
        // 删除指定的键值对
        ht.Remove("five");
        
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
        Dictionary<string, string> dict = new Dictionary<string, string>();

        var keys = dict.Keys;
    }
}