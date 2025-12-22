using System;

namespace MyConsoleApp.InsecureCodeApplication;

public class InsecureCode
{
    public static void Demo()
    {
        // 不安全代码
        // 当一个代码块使用 unsafe 修饰符标记时, C# 允许在函数中使用指针变量, 不安全代码或非托管代码是指使用了指针变量的代码块
        
        /*
         指针 是值为另一个变量的地址的变量, 即内存位置的直接地址, 就像其他变量或常量, 您必须在使用指针存储其他变量地址之前声明指针
         
         // 指针变量声明的一般形式为
         // type* var-name;
         */

    }

    public static unsafe void Test()
    {
        int number = 10;
        int* p = &number;
        
        Console.WriteLine($"Number: {number} Address: {(int)p} | 0x{(ulong)p:X} | {(long)p:X} | {(nint)p:X}");
        // 修改值
        *p = 100;
        Console.WriteLine($"Number: {number} Data is: {p->ToString()}");


        int[] list = new[] { 1, 2, 3, 4, 5 };
        fixed (int* ptr = list)
            Console.WriteLine($"\n{list}, {(int)ptr} | {(long)ptr:X} {(nint)ptr:X}");
        
        
    }
}