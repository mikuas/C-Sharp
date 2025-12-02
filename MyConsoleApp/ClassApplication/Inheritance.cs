using System;

namespace MyConsoleApp.ClassApplication;

/*
 * 创建派生类语法
 * 
 * <访问修饰符> class <基类>
 * {
 *  ...
 * }
 * class <派生类> : <基类>
 * {
 *  ...
 * }
 */
 
// 基类
public class Animal
{
    public string Name { get; set; } = "Animal";

    // abstract 子类必须覆写 但是必须是 abstract 类
    // public abstract void Speak();
    
    // 子类可选覆写
    public virtual void Eat()
    {
        Console.WriteLine($"父类方法, {Name} is eating");
    }
}


// 派生类, 只能继承一个父类, 但可以继承多个接口
public class Dog : Animal
{
    public Dog()
    {
        Name = "Dog";
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} 喝水");
    }

}


public class Cat : Animal
{
    public Cat()
    {
        Name = "Cat";
    }

    public override void Eat()
    {
        // 调用父类方法 使用 base 关键字
        base.Eat();
        Console.WriteLine($"{Name} 哈气");
    }
}


public class Inheritance
{
    public static void Demo()
    {
        Animal dog = new Dog();
        Animal cat = new Cat();
        
        dog.Eat();
        cat.Eat();
    }   
}


public class ExecuteInheritance
{
    public static void Run()
    {
        Inheritance.Demo();
    }
}