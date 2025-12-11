using System;
using System.IO;
using System.Text;

namespace MyConsoleApp.FilesIOApplication;

public class FileIO
{
    public FileIO FileRead(string filePath)
    {
        string result = File.ReadAllText(filePath);
        Console.WriteLine($"读取的文件内容: {result.Replace("\r", ",").Replace("\n", " ")}");

        return this;
    }

    public FileIO FileWrite(string filePath, string contents)
    {
        File.WriteAllText(filePath, contents);
        Console.WriteLine("文件写入成功");
        
        return this;
    }

    public FileIO FileWriteLines(string filePath, string[] contents)
    {
        File.WriteAllLines(filePath, contents);
        Console.WriteLine("写入行成功");

        return this;
    }

    public FileIO FileAppend(string filePath, string contents)
    {
        File.AppendAllText(filePath, contents);
        Console.WriteLine("文件追加成功");
        
        return this;
    }
    
    public static void Demo()
    {
        string filePath = @"C:\file.txt";
        string contents = Environment.NewLine;

        for (int i = 1; i <= 10; i++)
        {
            contents += $"Item {i}{Environment.NewLine}";
        }

        new FileIO()
            .FileRead(filePath)
            .FileWrite(filePath, "Write File")
            .FileAppend(filePath, contents)
            .FileRead(filePath)
            .FileWriteLines(filePath, new[] {"1", "2", "3", "4", "5"})
            .FileRead(filePath);
    }
}


public class ExecuteFileIO
{
    public static void Run()
    {
        FileIO.Demo();
    }
}