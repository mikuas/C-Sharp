using System;
using System.IO;

namespace MyConsoleApp.FilesIOApplication;

public class DirectoryInfo
{
    public static void Demo()
    {
        System.IO.DirectoryInfo di = new System.IO.DirectoryInfo("C:\\Projects");
        
        Console.WriteLine($"路径: {di.FullName}");                     // 获取目录或文件的完整路径
        Console.WriteLine($"文件属性: {di.Attributes}");                // 获取当前文件或目录的属性
        Console.WriteLine($"创建时间: {di.CreationTime}");              // 获取当前文件或目录的创建时间
        Console.WriteLine($"{di.FullName}是否存在: {di.Exists}");       // 判断目录是否存在
        Console.WriteLine($"{di.FullName}最后被访问的时间: {di.LastAccessTime}");   // 最后被访问的时间
        Console.WriteLine($"实例名称: {di.Name}");

        System.IO.DirectoryInfo edi = new System.IO.DirectoryInfo("C:\\Test");
        Console.WriteLine($"{edi.FullName}是否存在: {edi.Exists}");
        
        // 创建一个目录 如果存在就不创建
        di.Create();
        // 在指定的路径上创建子目录, 指定路径可以是相对于DirectoryInfo类的实例路径
        di.CreateSubdirectory("Test");
        // 如果为空,则删除DirectoryInfo  存在抛出异常 IOException
        try
        {
            di.Delete();
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        
        // 返回当前目录的子目录
        System.IO.DirectoryInfo[] subDirs = di.GetDirectories();
        foreach (System.IO.DirectoryInfo subDir in subDirs)
        {
            Console.WriteLine($"目录名: {subDir.Name}, 完整路径: {subDir.FullName}");
        }
        Console.WriteLine($"子目录数量: {subDirs.Length}");
        
        // 从当前目录返回文件列表
        System.IO.FileInfo[] files = di.GetFiles();
        foreach (System.IO.FileInfo file in files)
        {
            Console.WriteLine($"文件名: {file.Name}, 完整路径: {file.FullName}");
        }
        Console.WriteLine($"文件数量: {files.Length}");
    }
}


public class ExecuteDirectoryInfo
{
    public static void Run()
    {
        DirectoryInfo.Demo();
    }
}