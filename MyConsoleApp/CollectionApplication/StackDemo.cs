using System;
using System.Collections;
using System.Collections.Generic;


namespace MyConsoleApp.CollectionApplication;

public class StackDemo
{
    // 堆栈(Stack) 是一种后进先出(LIFO, Last In First Out)的数据结构

    public class Person
    {
        public Person(string? name)
        {
            Name = name;
        }
        
        public string? Name { get; set; }

        public override string ToString() => Name;
    }

    public static void Demo()
    {
        Stack stack = new Stack();
        
        // 将元素压入堆栈的顶部
        stack.Push(1);
        stack.Push("2");
        stack.Push('3');
        stack.Push(4);
        stack.Push(new Person("Tom"));
        stack.Push(new Person("Alex"));
        
        // 移除并返回堆栈的顶部元素
        var element = stack.Pop();
        Console.WriteLine($"移除顶部元素: {element}");
        
        // 返回堆栈的顶部元素, 但是不移除
        element = stack.Peek();
        Console.WriteLine($"返回顶部元素: {element}");
        
        // 确定某元素是否存在堆栈中
        bool contains = stack.Contains(4);
        Console.WriteLine($"5 是否存在于堆栈中: {contains}");
        contains = stack.Contains('4');
        Console.WriteLine($"\'2\' 是否存在于堆栈中: {contains}");
        
        // 将堆栈元素复制到新数组中(顺序反转)
        Console.WriteLine();
        var items = stack.ToArray();
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
        
        // 创建当前堆栈的浅表副本
        Stack result = (Stack)stack.Clone(); // 浅拷贝, 拷贝的引用数据类型是内存地址
        Console.WriteLine(result);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.WriteLine(result.Peek() == stack.Peek());
        Console.WriteLine(result == stack);
        
        Person v1 = (Person)stack.Peek();
        var v2 = result.Peek();

        // 修改 v1 的 Name, v2 的 Name 也会改变 
        v1.Name = "Jerry";

        Console.WriteLine($"{v1}\t{v2}");
        Console.WriteLine(v1.Name);
        
        // object[] items = new object[stack.Count];
        
        // 移除所有元素
        stack.Clear();

        Stack<string> stackT = new Stack<string>(new[]
        {
            "1",
            "2",
            "3",
            "4",
            "5",
        });

        foreach (string item in stackT)
        {
            Console.WriteLine(item);
        }
    }
}