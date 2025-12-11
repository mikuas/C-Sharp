using System;
using MySql.Data.MySqlClient;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 设置数据库连接字符串
            string connectionString = "Server=localhost;Database=demo;User ID=root;Password=root;CharSet=utf8";

            // 创建 MySqlConnection 对象
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // 打开连接
                    connection.Open();
                    Console.WriteLine("连接成功！");
                    // 执行一个简单的查询
                    string query = "SELECT * FROM a";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // 执行查询并获取数据
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(reader); // 根据列名获取数据
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("发生错误: " + ex.Message);
                }
                finally
                {
                    // 确保在最后关闭连接
                    connection.Close();
                    Console.WriteLine("连接已关闭。");
                }
            }
        }
    }
}