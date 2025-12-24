using System;
using System.IO;
using StudentManagerSystem.Enums;
using StudentManagerSystem.Services;
using StudentManagerSystem.Storage;


namespace StudentManagerSystem;

public class Program
{
    public static void ShowMainMenu()
    {
        Console.WriteLine("\n欢迎来到Interval学生管理系统, 请选择你的操作: ");
        Console.WriteLine("1. 添加学生");
        Console.WriteLine("2. 查询学生");
        Console.WriteLine("3. 更新学生");
        Console.WriteLine("4. 删除学生");
        Console.WriteLine("5. 查询所有学生");
        Console.WriteLine("0. 退出程序");
    }

    public static void Main(string[] args)
    {
        var service = new StudentService();
        
        while (true)
        {
            ShowMainMenu();
        
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("输入无效，请输入数字！");
                continue;
            }

            switch ((MenuOptions)choice)
            {
                case MenuOptions.Add:
                    service.AddStudent();
                    break;
            
                case MenuOptions.Query:
                    service.QueryStudent();
                    break;
            
                case MenuOptions.Update:
                    service.UpdateStudent();
                    break;
            
                case MenuOptions.Delete:
                    service.DeleteStudent();
                    break;
                
                case MenuOptions.ShowAll:
                    service.ShowAllStudent();
                    break;
                
                case MenuOptions.Exit:
                    service.Save();
                    return;
                
                default:
                    Console.WriteLine("无效选项，请重新输入！");
                    break;
            }
        }
    }
}