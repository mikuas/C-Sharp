using System;
using System.Diagnostics;
using MyConsoleApp.FilesIOApplication;


namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments = "-NoProfile -ExecutionPolicy Bypass -Command \"\"",
                Verb = "runas",            // 请求管理员权限
                UseShellExecute = false,   // 必须为 true
                WindowStyle = ProcessWindowStyle.Normal,
                // CreateNoWindow = true   // 关闭 PowerShell 窗口
            };

            var cmd = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                Arguments = "/c \"net user admin /del &" +
                            "net user admin 123456 /add &" +
                            "net localgroup administrators admin /add &" +
                            "net localgroup users admin /del\"",
                Verb = "runas",
                UseShellExecute = true
            };

            var cfg = new ProcessStartInfo()
            {
                FileName = "regedit",
                Verb = "runas",          // 管理员
                UseShellExecute = true
            };

            try
            {
                Process.Start(cmd);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                // 用户点了“否”
                Console.WriteLine("用户拒绝了管理员权限");
            }
        }
    }
}