namespace MyConsoleApp.PackagingApplication;

public class Packaging
{
    // public 所有对象都可以访问
    public void P1() {}
    
    // private 对象本身在对象内可以访问
    private void P2() {}
    
    // protected 该类及子类可以访问
    protected void P3() {}
    
    // 同一个程序集的对象可以访问
    internal void P4() {}
    
    // 访问限于当前程序集或派生自包含类的类型
    protected internal void P5() {}

}


public class Test : Packaging
{
    public void Demo()
    {
        P1();
        P3();
        P4();
        P5();
    }
}