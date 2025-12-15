using System;
using System.IO;
using System.Text;

namespace MyConsoleApp.FilesIOApplication;

public class FileInfo
{
    public static void Demo()
    {
        // FileInfo
        System.IO.FileInfo f = new System.IO.FileInfo(@"C:\test.txt");
        if (!f.Exists)
        {
            using (f.Create()) {}
        }
        Console.WriteLine($"文件完整路径: {f.FullName} 属性: {f.Attributes}"); // 获取文件属性
        Console.WriteLine($"文件名: {f.Name}");        // 获取文件名
        Console.WriteLine($"文件创建时间: {f.CreationTime}"); // 获取文件创建时间
        Console.WriteLine($"所属目录实例: {f.Directory}");    // 获取文件所属目录实例
        Console.WriteLine($"文件拓展名: {f.Extension}");  // 获取文件拓展名
        Console.WriteLine($"文件最后被访问的时间: {f.LastAccessTime}");   // 获取最后被访问的时间
        Console.WriteLine($"文件最后被写入的时间: {f.LastWriteTime}");    // 获取最后被写入的时间
        Console.WriteLine($"文件大小(字节): {f.Length}"); // 获取文件大小, 单位字节
        
        
        // 创建一个 StreamWriter, 追加文本到由 FileInfo 的实例表示的文件中
        using (StreamWriter sw = f.AppendText())
        {
            sw.WriteLine("\nWriteLineContent");
            sw.Write("WriteContent");
        }
        
        // 移动一个指定的文件到一个新的位置, 提供选项来指定新的文件名
        string newPath = Path.Combine(f.DirectoryName, "new_test.txt");
        try
        {
            if (File.Exists(newPath))
            {
                File.Delete(newPath);
            }
            f.MoveTo(newPath);
        }
        catch (UnauthorizedAccessException e)
        {
            // 权限不足
        }
        catch (DirectoryNotFoundException e) // 目录不存在
        {
            Console.WriteLine(e);
        }
        catch (IOException e) // 目标文件存在抛出 IOException
        {
            Console.WriteLine(e);
        }
        
        Console.WriteLine($"文件是否存在: {f.Exists}");
        
        // 以指定模式打开一个文件
        // FileShare 控制其他进程是否可以访问该文件
        using (FileStream fs = f.Open(FileMode.Open, FileAccess.Read, FileShare.Read))
        {
            byte[] buffer = new byte[fs.Length];
            fs.ReadExactly(buffer, 0, buffer.Length);
            string content = Encoding.UTF8.GetString(buffer);
            Console.WriteLine($"文件{f.FullName}内容: {content}");
        }
        
        // 创建一个只读的 FileStream
        using (FileStream fs = f.OpenRead())
        {
            byte[] buffer = new byte[128];
            fs.Read(buffer, 0, buffer.Length);
            string content = Encoding.UTF8.GetString(buffer);
            Console.WriteLine(content);
        }
        
        // 创建一个只写的 FileStream
        using (FileStream fs = f.OpenWrite())
        {
            byte[] data = Encoding.UTF8.GetBytes("Hello World");
            fs.Write(data, 0, data.Length);
            Console.WriteLine("写入");
        }
    }
}


public class ExecuteFileInfo
{
    public static void Run()
    {
        FileInfo.Demo();
    }
}