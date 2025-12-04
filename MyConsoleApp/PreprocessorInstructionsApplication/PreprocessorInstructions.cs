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

        
        // 标记一段代码区域
        #region MyRegion

        int count = 114;
        int width = 24;

        int result = count * width;

        #endregion
    }
}


public class ExecutePreprocessorInstructions
{
    public static void Run()
    {
        PreprocessorInstructions.Demo();
    }
}