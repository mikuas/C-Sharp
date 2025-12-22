using System;
using System.Collections;
using System.Collections.Generic;

namespace MyConsoleApp.CollectionApplication;


// 排序列表
public class SortedListDemo
{
    public static void Demo()
    {
        /*
        键值对存储: 每个键都唯一,与其关联的值可以重复
        动态调整容量: 根据需要自动调整内部存储的大小
        索引访问: 通过键或索引访问数据
        高效操作: 检索,插入,删除的平均时间复杂度为 O(log n)
         */
        
        // 一个“会自动排序的 Dictionary”
        SortedList sl = new SortedList();
        // 添加
        sl.Add("One", 1);
        sl.Add("Two", "Two");
        sl.Add("Three", 3);
        sl.Add("Four", "Four");
        sl.Add("Five", 5);
        foreach (var key in sl.Keys)
        {
            Console.WriteLine($"Key: {key}, Value: {sl[key]}");
        }
        Console.WriteLine();
        // 移除
        sl.Remove("Three");
        
        // 移除指定索引位置的键值对
        sl.RemoveAt(2);

        foreach (var key in sl.Keys)
        {
            Console.WriteLine($"Key: {key}, Value: {sl[key]}");
        }
        
        // 是否包含指定的键
        Console.WriteLine($"是否包含指定的键 Five: {sl.ContainsKey("Five")}");
        Console.WriteLine($"是否包含指定的键 Three: {sl.ContainsValue("Three")}\n");
        
        // 是否包含指定的索引
        Console.WriteLine($"是否包含指定的值 5: {sl.ContainsValue(5)}");
        Console.WriteLine($"是否包含指定的值 8: {sl.ContainsValue(8)}\n");

        int keyIndex = sl.IndexOfKey("Two");
        int valueIndex = sl.IndexOfValue(8);
        Console.WriteLine($"Key Five 的 Index: {keyIndex}, Value 5 的 Index: {valueIndex}\n");
        
        // 复制到数组
        DictionaryEntry[] items = new DictionaryEntry[sl.Count];
        sl.CopyTo(items, 0);
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
        
        // 移除所有元素
        sl.Clear();
        
        // 泛型
        SortedList<int, string?> dict = new SortedList<int, string?>()
        {
            {1, "One"},
            {2, "Two"},
            {3, "Three"},
            {4, "Four"},
            {5, "Five"},
        };

        IEnumerator<KeyValuePair<int, string?>> elements = dict.GetEnumerator();

        Console.WriteLine("--------------------");
        while (elements.MoveNext())
        {
            Console.WriteLine(elements.Current);
        }
        
        // 获取与指定键相关联的值, 如果存在则返回 True
        bool contains;
        contains = dict.TryGetValue(6, out var value);
        Console.WriteLine($"6 是否存在: {contains}, Value: {value}");
    }
}