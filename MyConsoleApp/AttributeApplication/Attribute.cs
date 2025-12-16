using System;
using MyConsoleApp.Demo;

namespace MyConsoleApp.AttributeApplication;

public class Attribute
{

    [Obsolete("此方法已经过时, 请使用NewMethod代替")]
    // 标记过时方法, 编译器会给出警告
    public void OldMethod()
    {
        Console.WriteLine("这个一个旧的方法");
    }

    [Serializable]
    // 标记类可序列化
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        [NonSerialized]
        private string _password; // 标记字段不进行序列化
    }

    // 自定义属性
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Struct)]
    public class BugFixAttribute: System.Attribute
    {
        public string Developer { get; }
        public string Date { get; }

        public BugFixAttribute(string developer, string date)
        {
            Developer = developer;
            Date = date;
        }
    }

    [BugFix("Alice", "2024-06-15")]
    public void NewMethod()
    {
        Console.WriteLine("这是一个新方法");
        // 运行时读取特性
        var attrs = typeof(Attribute).GetMethod("NewMethod").GetCustomAttributes(typeof(BugFixAttribute), false);
        foreach (BugFixAttribute attr in attrs)
        {
            Console.WriteLine($"此方法由 {attr.Developer} 修复于 {attr.Date}");
        }
    }

    [BugFix("Bob", "1145-14-19")]
    public class Test
    {
        public Test()
        {
            var attrs = typeof(Test).GetCustomAttributes(typeof(BugFixAttribute), false);
            foreach (BugFixAttribute attr in attrs)
            {
                Console.WriteLine($"此类由 {attr.Developer} 修复于 {attr.Date}");
            }
        }
    }


    public static void Demo()
    {
        Attribute a = new Attribute();
        a.OldMethod();
        a.NewMethod();
        Test t = new Test();
    }
}


public class ExecuteAttribute
{
    public static void Run()
    {
        Attribute.Demo();
    }
}