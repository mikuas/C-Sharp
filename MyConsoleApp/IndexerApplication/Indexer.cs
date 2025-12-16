using System;


namespace MyConsoleApp.IndexerApplication;
// 索引器

/*
索引器(Indexer) 允许一个对象可以像数组一样使用下标的方式来访问。
当您为类定义一个索引器时, 该类的行为就会像一个 虚拟数组(virtual array)一样。您可以使用数组访问运算符[ ]来访问该类的的成员
*/
public class Indexer
{
    private string[] _names = new string[size];
    static public int size = 10;

    public Indexer()
    {
        for (int i = 0; i < size; i++)
        {
            _names[i] = $"Null";
        }
    }

    // 定义索引器
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < size)
            {
                return _names[index];
            }
            return "";
        }
        set
        {
            if (index >= 0 && index < size)
            {
                _names[index] = value;
            }
        }
    }

    // 重载索引器
    public int this[string name]
    {
        get
        {
            for (int i = 0; i < size; i++)
            {
                if (_names[i] == name)
                {
                    return i;
                }
            }
            return 0;
        }
    }

    public override string ToString() => string.Join(", ", _names);

    public static void Demo()
    {
        Indexer ider = new Indexer();

        string[] tmp = new string[] { "Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Heidi", "Ivan", "Judy" };
        for (int i = tmp.Length - 1; i >= 0; i--)
        {
            ider[tmp.Length - i - 1] = tmp[i];
        }

        Console.WriteLine(ider.ToString());

        Console.WriteLine($"索引 6 的名字为: {ider[6]}");
        Console.WriteLine($"名字 Eve 的索引为: {ider["Eve"]}");
    }

}


public class ExecuteIndexer
{
    public static void Run()
    {
        Indexer.Demo();
    }
}