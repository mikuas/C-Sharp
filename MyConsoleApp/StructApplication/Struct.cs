using System;
namespace MyConsoleApp.StructApplication;


// 定义结构体
struct Books
{
    public string Title;
    public string Author;
    public string BookId;

    // 声明字段无法赋初始值
    // private int count = 1;

    public void SetValues(string title, string author, string bookId)
    {
        Title = title;
        Author = author;
        BookId = bookId;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"BookId: {BookId}");
    }
}

public class Point
{
    public int X;
    public int Y;
    
    public Point() {}

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

struct Student
{
    public string Name;
    public int Age;
    public char Gender;
    public string Phone;
    public string Email;

    // 不允许无参构造函数
    public Student(string name, int age, char gender, string phone, string email)
    {
        Name = name;
        Age = age;
        Gender = gender;
        Phone = phone;
        Email = email;
    }
    
}

public class Struct
{
    public static void Demo()
    {
        Books books;
        Student student = new Student();

        books.Title = "WPF";
        books.Author = "Tom";
        books.BookId = "0001";

        student.Name = "Tom";
        student.Age = 18;
        student.Gender = '男';
        student.Phone = "+8618456784512";
        student.Email = "example@gmail.com";
        
        Console.WriteLine($"Title: {books.Title},  Author: {books.Author}, BookId: {books.BookId}");
        Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Gender: {student.Gender}, Phone: {student.Phone}, Email: {student.Email}");
        
        
        // 结构是值类型, 分配在栈上
        Student s1 = new Student("ZhangSan", 19, '男', "+8617648954621", "example@outlook.com");
        Student s2 = s1; // 复制整个结构
        
        // 类是引用类型, 分配在堆上
        Point p1 = new Point(10, 20);
        Point p2 = p1; // 复制引用, 指向同一个对象

        s1.Name = "LiSi";
        Console.WriteLine($"s1 name: {s1.Name}, s2 name: {s2.Name}");

        p1.X = 1024;
        Console.WriteLine($"p1 X: {p1.X}, p2 X: {p2.X}");


        Books books1 = new Books();
        Books books2 = new Books();
        
        books1.SetValues("Widget", "Interval", "0001");
        books2.SetValues("Window", "Interval", "0002");
        
        books1.DisplayInfo();
        books2.DisplayInfo();
    }
}
    

public class ExecuteStruct
{
    public static void Run()
    {
        Struct.Demo();
    }
}