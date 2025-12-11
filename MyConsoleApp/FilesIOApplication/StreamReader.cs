using System;
using System.IO;
using System.Text;

namespace MyConsoleApp.FilesIOApplication;

public class StreamReader
{
    public StreamReader FileReadLine(string filePath, int lineCount = 3)
    {
        // 读取文本文件
        using (System.IO.StreamReader file = new System.IO.StreamReader(filePath, Encoding.UTF8))
        {
            string line;
            // 从文件中读取行
            for (int i = 0; i < lineCount; i++)
            {
                Console.WriteLine(file.ReadLine());
            }
            // while ((line = file.ReadLine()) != null)
            // {
                // Console.WriteLine(line);
            // }
        }

        return this;
    }

    public StreamReader FileReadToEnd(string filePath)
    {

        return this;
    }
    
    
    public static void Demo()
    {
        string filePath = @"C:\test.txt";
        
        new StreamReader()
            .FileReadLine(filePath);
    }
}


public class ExecuteStreamReader
{
    public static void Run()
    {
        StreamReader.Demo();
    }
}