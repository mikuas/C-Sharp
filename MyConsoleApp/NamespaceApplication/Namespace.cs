using System;
using MyConsoleApp.NamespaceOne;
using MyConsoleApp.NamespaceTwo;
using MyConsoleApp.NamespaceThree;

using MyConsoleApp.NamespaceOne.MyConsoleApp.NamespaceOne.SubNamespace;


namespace MyConsoleApp.NamespaceOne
{
    // 嵌套命名控件
    namespace MyConsoleApp.NamespaceOne.SubNamespace
    {
        public class Test1Sub
        {
            public Test1Sub()
            {
                new Test1().Print();
                new Test2().Print();
                new Test3().Print();
            }

            public static void Demo()
            {
                new Test1Sub();
            }
        }
    }
    
    public class Test1
    {
        public void Print()
        {
            Console.WriteLine("Test1 Print");
        }
    }
}

namespace MyConsoleApp.NamespaceTwo
{
    public class Test2
    {
        public void Print()
        {
            Console.WriteLine("Test2 Print");
        }
    }
}

namespace MyConsoleApp.NamespaceThree
{
    public class Test3
    {
        public void Print()
        {
            Console.WriteLine("Test3 Print");
        }
    }
}