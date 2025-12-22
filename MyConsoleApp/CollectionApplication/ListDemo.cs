using System;
using System.Collections;
using System.Collections.Generic;

namespace MyConsoleApp.CollectionApplication;

public class ListDemo
{
    // List
    public static void Demo()
    {
        // 泛型, 强类型约束, 和ArrayList一样的用法
        List<int> intList = new List<int>();

        for (int i = 1; i <= 10; i++)
        {
            intList.Add(i);
        }
        
        intList.Insert(10, 100);
        
        Print(intList);

        List<bool> boolList = new List<bool>();
        List<string> stringList = new List<string>();
        List<double> doubleList = new List<double>();
        List<float> floatList = new List<float>();
        List<char> charList = new List<char>();
    }

    public static void Print(IEnumerable element)
    {
        foreach (var item in element)
        {
            Console.WriteLine(item);    
        }
    }
}