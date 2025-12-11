using System;
using System.IO;
using System.Text;

namespace MyConsoleApp.FilesIOApplication;

// C-Sharp C#

public class FileStreamIO
{
    public void ReadFile(string filePath)
    {
        // 使用 FileStream
        // 读取字节流
        try
        {
            using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[file.Length];
                file.Read(buffer, 0, buffer.Length);
                string content = Encoding.UTF8.GetString(buffer);
                
                Console.WriteLine($"读取的文件内容: {content}");
            }
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"指定文件路径不存在, 文件: {e.FileName}, 错误: {e.Message}");
        }
    }

    public void WriteFile(string filePath, string content)
    {
        using (FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            byte[] data = Encoding.UTF8.GetBytes(content);
            file.Write(data, 0, data.Length);
            
            Console.WriteLine("写入成功");
        }
    }

    public void AppendFile(string filePath, string[] contents)
    {
        using (FileStream file = new FileStream(filePath, FileMode.Append, FileAccess.Write))
        {
            foreach (string line in contents)
            {
                // 将内容转为字节并添加换行符
                byte[] data = Encoding.UTF8.GetBytes(Environment.NewLine + line);
                file.Write(data, 0, data.Length);
            }

            Console.WriteLine("追加成功");
        }
    }

    public void Test()
    {
        try
        {
            // 使用 FileStream 打开文件进行读取
            using (FileStream file = new FileStream(@"C:\0.jpeg", FileMode.Open, FileAccess.Read))
            {
                // 创建一个字节数组来存储文件的所有数据
                byte[] fileBytes = new byte[file.Length];

                // 读取文件内容到字节数组
                file.Read(fileBytes, 0, (int)file.Length);

                // 打印文件的前几个字节（十六进制）
                Console.WriteLine("文件的前几个字节（十六进制表示）:");
                for (int i = 0; i < 10 && i < fileBytes.Length; i++) // 打印前10个字节
                {
                    Console.Write($"{fileBytes[i]:X2} ");
                }
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"读取文件时发生错误: {ex.Message}");
        }
    }
    
    public static void Demo()
    {
        string readFilePath, writeFilePath, appendFilePath;

        readFilePath = @"C:\test.txt";
        writeFilePath = @"C:\1.txt";
        appendFilePath = @"C:\1.txt";

        string[] lines =
        {
            "追加的第一行内容",
            "追加的第二行内容",
            "追加的第三行内容"
        };
        
        FileStreamIO fileIo = new FileStreamIO();
        fileIo.ReadFile(readFilePath);
        fileIo.WriteFile(writeFilePath, "This is Test Content");
        fileIo.AppendFile(appendFilePath, lines);
        fileIo.Test();
    }
}


public class ExecuteFileStreamIO
{
    public static void Run()
    {
        FileStreamIO.Demo();
    }
}