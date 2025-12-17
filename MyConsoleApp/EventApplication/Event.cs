using System;
using System.Threading;


namespace MyConsoleApp.EventApplication;

// 事件声明
// 在类的内部声明事件 首先必须声明该事件的委托类型
public delegate void NotifyEventHandler(object sender, EventArgs e);

public class ProcessBusinessLogic
{
    // 声明事件
    // 通常使用 EventHandler 或 EventHandler<TEventArgs> 来替代自定义的委托
    public event NotifyEventHandler? ProcessCompleted;
    
    // 触发事件的方法
    protected virtual void OnProcessCompleted(EventArgs e)
    {
        ProcessCompleted?.Invoke(this, e);
    }

    public void StartProcess()
    {
        Console.WriteLine("Process Started!");
        
        Thread.Sleep(2500);
        
        // 结束触发事件
        OnProcessCompleted(EventArgs.Empty);
    }
}


public class EventSubscriber
{
    public void Subscribe(ProcessBusinessLogic process)
    {
        process.ProcessCompleted += ProcessProcessCompleted;
    }

    public void ProcessProcessCompleted(object sender, EventArgs e)
    {
        Console.WriteLine("Process Completed!");
    }
}


public class ExecuteEvent
{
    public static void Run()
    {
        ProcessBusinessLogic process = new ProcessBusinessLogic();
        EventSubscriber subscriber = new EventSubscriber();
        
        // 订阅事件
        subscriber.Subscribe(process);
        // 启动过程
        process.StartProcess();
        
        // 取消订阅
        process.ProcessCompleted -= subscriber.ProcessProcessCompleted;
        process.StartProcess();
    }
}