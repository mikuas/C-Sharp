using System;


namespace MyConsoleApp.PropertyApplication;

public class Property
{

    public class Person
    {
        private string _name;
        private int _age;
        private char _gender;

        public string Name
        {
            get => _name;
            set
            {
                value = value.Trim();
                if (value == "")
                {
                    throw new ArgumentException("名字不能为空");
                }
                _name = value;
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value <= 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("年龄不合法!");
                }
                _age = value;
            }
        }

        public char Gender
        {
            get => _gender;
            set
            {
                // if (value is not ('男' or '女')) {}
                if (value != '男' && value != '女')
                {
                    throw new ArgumentException("性别只能是 男 或 女");
                }
                _gender = value;
            }
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Gender: {Gender}");
        }
    }

    public static void Demo()
    {
        Person p = new Person();

        try
        {
            p.Name = "张三";
            p.Age = 24;
            p.Gender = '男';

            p.Name = "   李四         ";
            p.Age = -1;
            p.Gender = '狗';
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            return;
        }
        finally
        {
            p.Display();
        }
    }

    // Abstract Properties 抽象属性
    public abstract class Base
    {
        public abstract string Name { get; set; }
        public abstract int Age { get; set; }

    }

    public class Student : Base {
        public string Code { get; set; } = "N.A";
        public override string Name { get; set; } = "N.A";
        public override int Age { get; set; } = 0;
        public override string ToString() => $"Code: {Code}, Name: {Name}, Age: {Age}";
    }
}



public class ExecuteProperty
{
    public static void Run()
    {
        Property.Demo();
    }
}