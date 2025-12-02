#define DEBUG       // 定义一个符号, 可以用于条件编译
#undef DEBUG        // 取消定义一个符号
#define RELEASE

#define ljw_is_gay

#undef RELEASE

using System;


namespace MyConsoleApp.PreprocessorInstructionsApplication;

public class PreprocessorInstructions
{
    public static void Demo()
    {
        #if DEBUG
            Console.WriteLine("Debug Mode");
        #elif RELEASE
            Console.WriteLine("Release Mode");
        #else
            Console.WriteLine("Other Mode");
        #endif
    }
}