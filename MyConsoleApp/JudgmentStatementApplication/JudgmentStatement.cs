using System;

namespace MyConsoleApp.JudgmentStatementApplication;

public class JudgmentStatement
{

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; } = "China";
        public char Gender { get; set; } = '男';

        public string GetStudentInfo() => $"name: {Name}, age: {Age}, address: {Address}, gender: {Gender}";
    }

    public JudgmentStatement NullTest()
    {
        // 判断是否为null
        string name = null;
        int? age = 5;

        if (name != null)
        {
            Console.WriteLine("name is not null");
        }
        else
        {
            Console.WriteLine("name is null");
        }

        if (age != null)
        {
            Console.WriteLine($"age is not null, age: {age}");
        }
        
        // null 条件运算符
        // 访问成员
        Student student = null;
        // Student student = new Student();
        string studentName = student?.Name;  // 返回 null，不会抛出异常
        string studentInfo = student?.GetStudentInfo();
        // string studentName = student.Name;
        Console.WriteLine(studentName);
        Console.WriteLine(studentInfo);
        
        // 访问元素
        int[]? list = null;
        int? a = list?[0];
        
        // 返回null
        Console.WriteLine(a);

        list = new int[] { 1, 2, 3, 4, 5 };
        a = list?[1];
        Console.WriteLine(a);
        
        return this;
    }

    public JudgmentStatement IfStatement()
    {
        // ? 运算符

        int a = 1;
        int b = 10;
        int max = a > b ? a : b;
        int min;

        if (a > b)
        {
            // 条件为真执行
            min = b;
        }
        else if (a == b)
        {
            // 嵌套if语句
            if (a == b && b == max)
            {
                min = max;
            }
            else
            {
                min = 0;
            }
        }
        else
        {
            // 条件为假执行
            min = a;
        }
        
        Console.WriteLine($"{max}\n{min}");

        return this;
    }

    public JudgmentStatement SwitchStatement()
    {
        int day = 7;
        int month = 3;
        switch (month)
        {
            case 3:
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("无效");
                        break;
                }
                break;
        }
        return this;
    }
    
    public static void Demo()
    {
        new JudgmentStatement().IfStatement().SwitchStatement().NullTest();
    }
}


public class ExecuteJudgmentStatement
{
    public static void Run()
    {
        JudgmentStatement.Demo();
    }
}