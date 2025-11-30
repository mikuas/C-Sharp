using System;

namespace MyConsoleApp.OperatorApplication;

public class LogicalOperators
{

    public LogicalOperators LogicAndOperations(bool a, bool b)
    {
        Console.WriteLine($" {a} && {b}: {a && b}");
        return this;
    }

    public LogicalOperators LogicOrOperations(bool a, bool b)
    {
        Console.WriteLine($" {a} || {b}: {a || b}");
        return this;
    }

    public LogicalOperators LogicIsNotAnOperation(bool a)
    {
        Console.WriteLine($" {a}, !{a}: {!a}");
        return this;
    }

    public static void Demo()
    {
        new LogicalOperators()
            .LogicAndOperations(false, false).LogicAndOperations(true, true).LogicAndOperations(false, true).LogicAndOperations(true, false)
            .LogicOrOperations(false, false).LogicOrOperations(false, true).LogicOrOperations(true, true).LogicOrOperations(true, false)
            .LogicIsNotAnOperation(false).LogicIsNotAnOperation(true);
    }
}


public class ExecuteLogicalOperators
{
    public static void Run()
    {
        LogicalOperators.Demo();
    }
}