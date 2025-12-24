using System;
using System.Globalization;
using System.Threading;

namespace MyConsoleApp.MultiThreadApplication;

public class MultiThread
{
    public static void Demo()
    {
        // 多线程
        Thread th = Thread.CurrentThread;
        
        Thread thread1 = new Thread(() => Console.WriteLine("Thread1 Start!"));
        Thread thread2 = new Thread(() =>
        {
            Console.WriteLine("Thread2 Start!");
            Thread.Sleep(2500);
            Console.WriteLine("\nThread2 End!");
        });
        
        // 前台 | 后台线程
        thread1.IsBackground = true;
        thread2.IsBackground = false;
        
        thread1.Start();
        thread2.Start();

        Console.WriteLine("End");
        
        // 获取线程正在其中执行的当前上下文
        
        // 获取或设置当前线程的区域性
        CultureInfo ci = th.CurrentCulture;
        Console.WriteLine($"\nMain Thread 的区域性: {ci}");
        // 获取或设置当前线程的当前负责人 (对于基于角色的安全性而言)
        
        // 获取或设置资源管理器使用的当前区域性以便在运行时查找区域性特定的资源
        CultureInfo cuic = th.CurrentUICulture;
        Console.WriteLine($"Main Thread 的资源管理器使用的当前区域性: {cuic}");

        // 获取一个 ExecutionContext对象, 该对象包含有关当前线程的各种上下文信息
        ExecutionContext? ec = th.ExecutionContext;
        Console.WriteLine($"Main Thread ExecutionContext对象: {ec}");
        
        // 线程执行状态
        bool isAlive = th.IsAlive;
        Console.WriteLine($"Main Thread IsAlive: {isAlive}");
        
        // 是否为后台线程
        bool isBackground = th.IsBackground;
        Console.WriteLine($"Main Thread IsBackground: {isBackground}");
        
        // 线程是否属于托管线程池
        bool isThreadPoolThread = th.IsThreadPoolThread;
        Console.WriteLine($"Main Thread IsThreadPoolThread: {isThreadPoolThread}");
        
        // 获取当前托管线程的唯一标识符
        int id = th.ManagedThreadId;
        Console.WriteLine($"Main Thread ManagedThreadId: {id}");
        
        // 获取当前线程名称
        string? name = th.Name;
        th.Name = "Main Thread";
 
        Console.WriteLine($"Main Thread Name: {name}");

        // 获取线程的调度优先级
        ThreadPriority tp = th.Priority;
        Console.WriteLine($"Main Thread Priority: {tp}");

        // 获取线程状态
        ThreadState ts = th.ThreadState;
        Console.WriteLine($"Main Thread State: {ts}");
        
        Console.WriteLine("--------------------------------------------------");
        
        // 中断处于 WaitSleepJoin线程状态的线程
        th.Interrupt();

        // 在继续执行标准的 COM 和 SendMessage 消息泵处理期间 阻塞调用线程 直到某个线程终止为止 此方法有不同的重载形式
        // th.Join();
        
        // 开启一个线程
        // thread1.Start();
        
        // 让线程暂停一段时间
        // Thread.Sleep(1000);

        Thread.Yield();
    }
}