using System;
namespace MyConsoleApp.StringApplication;

public class String
{
    public void Demo()
    {
        string name, gender;
        name = "Tom";
        gender = "Man";
        
        // 字符串拼接
        string result = name + gender;
        Console.WriteLine($"name: {name}, gender: {gender}, name + gender: {result}");
        
        // 通过构造函数
        char[] letters = {'H', 'e', 'l', 'l', 'o', 'W', 'o', 'r', 'l', 'd', '!'};
        string words = new string(letters);
        Console.WriteLine($"words: {words}");
        
        // 
        string[] sarray = { "Hello", "From", "Tutorials", "Point" };
        string message = System.String.Join(" ", sarray);
        Console.WriteLine($"Message: {message}");

        // 用于转换值的格式方法
        DateTime date = new DateTime(2025, 6, 15, 16, 4, 0);
        string chat = System.String.Format("Message sent at {0:t} on {0:D}", date);
        Console.WriteLine(chat);


        string chars1 = "Hello ";
        string chars2 = "World!";
        
        // 连接两个string对象
        result = System.String.Concat(chars1, chars2);
        Console.WriteLine(result);

        char a = 'l';
        // 返回 l 在 reult 里第一次出现的索引
        int index = result.IndexOf(a);
        Console.WriteLine($"l 在 {result} 第一次出现的索引: {index}");

        string b = "W";
        string c = "C";
        bool isContains = result.Contains(b);
        Console.WriteLine($"{b} 是否在 {result} 里出现: {isContains}");
        
        isContains = result.Contains(c);
        Console.WriteLine($"{c} 是否在 {result} 里出现: {isContains}");
        
        // 比较两个字符串是否具有相同的值
        string str1, str2, str3;
        str1 = "String";
        str2 = "String";
        str3 = "Char";
        
        Console.WriteLine($"{str1} 和 {str2} 是否具有相同的值: {System.String.Equals(str1, str2)}");
        Console.WriteLine($"{str1} 和 {str3} 是否具有相同的值: {System.String.Equals(str1, str3)}");
        
         // 判断结尾是否匹配指定字符串
         Console.WriteLine($"{str3} 结尾是否为 r: {str3.EndsWith("r")}, 是否为 R: {str3.EndsWith("R")}");

         string str4 = "HeLlo wORlD";
         Console.WriteLine($"{str4} 转为大写: {str4.ToUpper()}, 转为小写: {str4.ToLower()}");
    }
}


public class ExecuteString
{
    public static void Run()
    {
        new String().Demo();
    }
}