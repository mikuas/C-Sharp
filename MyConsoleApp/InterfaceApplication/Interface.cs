using System;

namespace MyConsoleApp.InterfaceApplication;

// 定义接口
interface IParentInterface
{
    // 接口不能有构造函数
    void ParentInterfaceMethod();
}

interface ICenterInterface
{
    void CenterInterfaceMethod();
}

// 继承接口
interface IMyInterface : IParentInterface, ICenterInterface
{
    void MyInterfaceMethod();
}

public class Interface : IMyInterface
{
    private Interface()
    {
        ParentInterfaceMethod();
        MyInterfaceMethod();
        CenterInterfaceMethod();
    }

    public void ParentInterfaceMethod()
    {
        Console.WriteLine("ParentInterfaceMethod");
    }

    public void MyInterfaceMethod()
    {
        Console.WriteLine("MyInterfaceMethod");        
    }

    public void CenterInterfaceMethod()
    {
        Console.WriteLine("CenterInterfaceMethod");
    }

    public static void Demo()
    {
        new Interface();
    }
}


public class ExecuteInterface()
{
    public static void Run()
    {
        Interface.Demo();
    }
}