using System;
using System.IO;

namespace MyConsoleApp.DelegateApplication;

public class Delegate
{
    // 委托

    /*
        委托是一个引用类型, 它定义了一个方法签名, 可以用于存储指向该签名的方法 通过委托 你可以调用其他类中的方法
        委托声明决定了可由该委托引用的方法 委托可指向一个与其具有相同标签的方法
        声明委托的语法如下
        */
    
    // public delegate 返回类型 委托名(参数类型 参数名, ...);
    public delegate int NumberChanged(int x);

    public static int number = 10;

    public static int AddNumber(int x)
    {
        number += x;
        return number;
    }

    public static int MultNumber(int x)
    {
        number *= x;
        return number;
    }

    public static int GetNumber() => number;

    public static void Demo()
    {
        // 创建委托实例
        NumberChanged n1 = new NumberChanged(AddNumber);
        NumberChanged n2 = new NumberChanged(MultNumber);

        // 使用委托调用方法
        Console.WriteLine($"初始值: {GetNumber()}");
        n1(20);
        Console.WriteLine($"AddNumber 20 后的值: {GetNumber()}");
        n2(5);
        Console.WriteLine($"MultNumber 5 后的值: {GetNumber()}");

        // 委托的多播 Multicasting of a Delegate
        // 委托对象可使用 + 运算符进行合并
        // 一个合并委托调用它所合并的两个委托, 只有相同类型的委托可被合并
        // - 运算符可用于从合并的委托中移除组件委托

        number = 0;
        NumberChanged allN;
        NumberChanged dn1 = new NumberChanged(AddNumber);
        NumberChanged dn2 = new NumberChanged(MultNumber);

        allN = dn1 + dn2;
        Console.WriteLine($"初始值: {GetNumber()}");
        allN(10); // 先执行 number + 10 然后执行 number * 10
        Console.WriteLine($"AddNumber 10 And MultNumber 10 后的值: {GetNumber()}");
    }
}


public class PrintString
{
    private static FileStream fs;
    private static StreamWriter sw;
    
    // 声明委托
    public delegate void PrintMessage(string str);
    
    // 打印到控制台
    public static void WriteToScreen(string str)
    {
        Console.WriteLine($"Write To Screen: {str}");
    }
    
    // 写入到文件
    public static void WriteToFile(string str)
    {
        fs = new FileStream(@"C:\message.txt", FileMode.Append, FileAccess.Write);
        sw = new StreamWriter(fs);
        
        sw.WriteLine(str);
        sw.Flush();
        sw.Close();
        fs.Close();
    }
    
    // 把委托作为参数, 并使用他的方法调用
    public static void SendString(PrintMessage pr)
    {
        pr("Hello World!");
    }

    public static void PrintUpperCase(string str)
    {
        Console.WriteLine(str.ToUpper());
    }

    public static void PrintLowerCase(string str)
    {
        Console.WriteLine(str.ToLower());
    }
    
    public static void Demo()
    {
        // PrintMessage ps1 = new PrintMessage(WriteToScreen);
        // PrintMessage ps2 = new PrintMessage(WriteToFile);
        //
        // SendString(ps1);
        // SendString(ps2);

        PrintMessage pm = new PrintMessage(PrintUpperCase); // = PrintUpperCase
        pm += new PrintMessage(PrintLowerCase); // += PrintLowerCase
        
        // 使用 -= 移除
        pm -= PrintUpperCase;
        
        pm("Hello World!");
        
        // 无返回值
        Action print = () => Console.WriteLine("Hello World!");
        Action<string> printEle = message => Console.WriteLine(message);
        // 有返回值
        Func<int> func = () => 10 + 10;
        // 返回 bool 值
        Predicate<int> pre = x => x > 0;

        print();
        printEle("Hello C#");
        Console.WriteLine(func());
        Console.WriteLine(pre(20));
    }
}


public class Button
{
    // 委托通常和事件一起使用, 事件是一种特殊类型的委托
    // 在C#中, 事件本质上就是一个封装了委托的类型

    // 定义一个事件
    public event EventHandler? Click;
    public event EventHandler<DoubleClickEventArgs>? DoubleClick;
    
    // 引发事件的方法
    public void OnClick() => Click?.Invoke(this, EventArgs.Empty);

    public void OnDoubleClick() => DoubleClick?.Invoke(this, new DoubleClickEventArgs(100, 100));

    public void OnDoubleClick(int x, int y) => DoubleClick?.Invoke(this, new DoubleClickEventArgs(x, y));

    public class DoubleClickEventArgs : EventArgs
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        public DoubleClickEventArgs(int x, int y) { X = x; Y = y; }
    }

    public static void Demo()
    {
        Button button = new Button();
        button.Click += ButtonClick;

        Button doubleButton = new Button();
        doubleButton.DoubleClick += ButtonDoubleClick;

        // 触发按钮点击事件
        button.OnClick();
        doubleButton.OnDoubleClick();
        doubleButton.OnDoubleClick(114, 514);
    }

    public static void ButtonClick(object sender, EventArgs e)
    {
        Console.WriteLine("Button Clicked");
    }

    public static void ButtonDoubleClick(object sender, DoubleClickEventArgs e)
    {
        Console.WriteLine($"Button Double Clicked, Position X: {e.X}, Y: {e.Y}");
    }
}


public class ExecuteDelegate
{
    public static void Run()
    {
        Delegate.Demo();
        PrintString.Demo();
    }
}