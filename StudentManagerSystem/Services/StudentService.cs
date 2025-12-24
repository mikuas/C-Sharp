using System;
using System.IO;
using System.Collections.Generic;
using StudentManagerSystem.Enums;
using StudentManagerSystem.Models;
using StudentManagerSystem.Storage;


namespace StudentManagerSystem.Services;

public class StudentService : IStudentService
{
    private readonly Dictionary<string, Student> _students;
    private readonly JsonStudentStorage _storage;
    private readonly string _path = Path.Combine(AppContext.BaseDirectory, "data", "students.json");

    public StudentService()
    {
        _storage = new JsonStudentStorage(_path);
        _students = _storage.Load();
    }

    public void AddStudent()
    {
        string id = ReadId();
        if (_students.ContainsKey(id))
        {
            Console.WriteLine("学号已存在！");
            return;
        }

        string name = ReadNonEmptyString("请输入姓名: ");
        char gender = ReadGender();
        int age = ReadAge();
        
        Student student = new Student()
        {
            Id = id,
            Name = name,
            Gender = gender,
            Age = age
        };

        _students[id] = student;
        Console.WriteLine($"添加学生信息成功\n信息: {student}");
    }
    
    public void QueryStudent()
    {
        if (CheckEmpty()) return;
        
        Student? student = SelectStudent();
        if (student is null) return;
        
        Console.WriteLine(student);
    }

    public void UpdateStudent()
    {
        if (CheckEmpty()) return;
        
        Student? student = SelectStudent();
        if (student is null) return;
        
        while (true)
        {
            ShowUpdateMenu();
            
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("输入无效，请输入数字！");
                continue;
            }

            switch ((UpdateMenuOptions)choice)
            {
                case UpdateMenuOptions.Name:
                    UpdateStudentName(student);
                    break;

                case UpdateMenuOptions.Gender:
                    UpdateStudentGender(student);
                    break;

                case UpdateMenuOptions.Age:
                    UpdateStudentAge(student);
                    break;

                case UpdateMenuOptions.Exit:
                    return;

                default:
                    Console.WriteLine("无效选项, 请重新输入!");
                    break;
            }
        }
    }

    public void DeleteStudent()
    {
        if (CheckEmpty()) return;
        
        Student? student = SelectStudent();
        if (student is null) return;

        bool result = _students.Remove(student.Id);
        Console.WriteLine(result ? "删除成功!" : "删除失败");
    }

    public void ShowAllStudent()
    {
        if (CheckEmpty()) return;
        
        foreach (var student in _students.Values)
        {
            Console.WriteLine(student);
        }
    }

    private void ShowUpdateMenu()
    {
        Console.Write("请选择操作: ");
        Console.WriteLine("1. 修改姓名");
        Console.WriteLine("2. 修改性别");
        Console.WriteLine("3. 修改年龄");
        Console.WriteLine("0. 退出");
    }

    private void UpdateStudentName(Student student)
    {
        student.Name = ReadNonEmptyString("请输入新的姓名: ");
        Console.WriteLine("姓名修改成功！");
    }

    private void UpdateStudentGender(Student student)
    {
        student.Gender = ReadGender();
        Console.WriteLine("性别修改成功！");
    }
    
    private void UpdateStudentAge(Student student)
    {
        student.Age = ReadAge();
        Console.WriteLine("年龄修改成功！");
    }

    private Student? SelectStudent()
    {
        string id = ReadId();
        if (!_students.TryGetValue(id, out Student? student))
        {
            Console.WriteLine("ID不存在!");
            return null;
        }

        return student;
    }

    private string ReadId()
    {
        while (true)
        {
            Console.WriteLine("请输入ID: ");

            string? id = Console.ReadLine()?.Trim();
            if (!string.IsNullOrWhiteSpace(id))
            {
                return id;
            }
            Console.WriteLine("ID输入无效!");
        }
    }

    private int ReadAge()
    {
        while (true)
        {
            Console.WriteLine("请输入年龄: ");

            string? input = Console.ReadLine()?.Trim();

            if (int.TryParse(input, out int age) && (age > 0 && age <= 100))
            {
                return age;
            }
            Console.WriteLine("年龄输入不合法!");
        }
    }

    private string ReadNonEmptyString(string s)
    {
        while (true)
        {
            Console.Write(s);
            string? input = Console.ReadLine()?.Trim();

            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            Console.WriteLine("输入不能为空, 请重新输入!");
        }
    }

    private char ReadGender()
    {
        while (true)
        {
            Console.WriteLine("请输入性别(男 | 女): ");
            string? input = Console.ReadLine()?.Trim();

            if (char.TryParse(input, out char gender) && (gender == '男' || gender == '女'))
            {
                return gender;
            }
            Console.WriteLine("性别输入无效!");
        }
    }
    
    private bool CheckEmpty()
    {
        if (_students.Count == 0)
        {
            Console.WriteLine("暂无学生信息, 请添加后在试!");
            return true;
        }
        return false;
    }

    public void Save()
    {
        if (CheckEmpty()) return;
        _storage.Save(_students);
    }

}