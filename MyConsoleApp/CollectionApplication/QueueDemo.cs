using System;
using System.Collections;
using System.Collections.Generic;


namespace MyConsoleApp.CollectionApplication;

public class QueueDemo
{
    // 队列
    // 在 C# 中, Queue 是一个先进先出(FIFO, First In First Out)数据结构

    public static void Demo()
    {
        Queue queue = new Queue();
        
        // 将元素添加到队列的末尾
        queue.Enqueue("Hello World!");
        queue.Enqueue("C#");
        queue.Enqueue("Queue");
        queue.Enqueue(1);
        
        // 移除并返回队列的开头
        var ele = queue.Dequeue();
        Console.WriteLine($"移除并返回队列的开头: {ele}");
        
        // 返回队列开头的元素,但是不移除
        ele = queue.Peek();
        Console.WriteLine($"队列开头的元素: {ele}");
        
        // 确定某元素是否在队列中
        bool contains1 = queue.Contains("Queue");
        bool contains2 = queue.Contains("C");
        
        Console.WriteLine($"\nQueue是否在队列中: {contains1}\nC是否在队列中: {contains2}");
        
        Console.WriteLine($"\n队列的元素数量: {queue.Count}\n");
        
        // 枚举容器
        IEnumerator items = queue.GetEnumerator();
        while (items.MoveNext())
        {
            Console.WriteLine($"Current Item: {items.Current}");
        }
        
        // 清除所欲元素
        queue.Clear();

        Queue<int> queueT = new Queue<int>(new[]
        {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9
        });
    
        Console.WriteLine();
        Queue<int>.Enumerator enumerator = queueT.GetEnumerator();
        while (enumerator.MoveNext())
        {
            Console.WriteLine($"Current Item: {enumerator.Current}");
        }
    }
}