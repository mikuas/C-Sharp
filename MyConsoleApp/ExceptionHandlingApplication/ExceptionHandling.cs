using System;

namespace MyConsoleApp.ExceptionHandlingApplication;

public class ExceptionHandling
{

    public ExceptionHandling()
    {
        // 异常处理

        if (false)
            try
            {
                // 引起异常的语句
                int a = int.Parse("abc");

            }
            catch (DivideByZeroException e1)
            {
                // 错误处理代码
                Console.WriteLine("TypeLoadException: {0}", e1.Message);
            }
            catch (Exception e2)
            {
                // 错误处理代码
                Console.WriteLine("Exception: {0}", e2.Message);
            }
            finally
            {
                // 要执行的语句
                Console.WriteLine("Finally");
            }
    }

    public ExceptionHandling IndexOutOfRangeExceptionHandling()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        for (int i = 0; i <= array.Length; i++)
        {
            try
            {
                Console.WriteLine($"Index: {i}, Value: {array[i]}");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("列表索引超出范围, {0}", e.Message);
            }
        }

        return this;
    }

    public ExceptionHandling DivideByZeroExceptionHandling()
    {
        int a, b, result;
        a = 10;
        b = 0;
        try
        {
            result = a / b;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("0不能做除数, {0}", e.Message);
        }
        finally
        {
            Console.WriteLine($"a: {a}, b: {b}");
        }

        return this;
    }

    public void CustomExceptionHandling()
    {
        Custom c = new Custom(-2);
        try
        {
            c.ShowCustom();
        }
        catch (CustomException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    
    public static void Demo()
        {
            new ExceptionHandling().IndexOutOfRangeExceptionHandling()
                .DivideByZeroExceptionHandling()
                .CustomExceptionHandling();
        }
    }


// 自定义异常
public class CustomException : ApplicationException
{
    public CustomException(string message) : base(message) { }
}


public class Custom
{
    private int Age;
    
    public Custom(int age)
    {
        Age = age;
    }


    public void ShowCustom()
    {
        if (Age <= 0)
        {
            throw new CustomException("Age LessThanOrEqualTo Zero Error");
        }
        else
        {
            Console.WriteLine($"Age: {Age}");
        }
    }
}


public class ExecuteExceptionHandling
{
    public static void Run()
    {
        ExceptionHandling.Demo();
    }
}