using AccessModifierProject.ConsoleApp.Models1;
using static System.Net.Mime.MediaTypeNames;

namespace AccessModifierProject.ClassLibrary;

public class Class1
{
    private readonly Test1 _test;
    private readonly TestInterface _interface;
    public Class1(Test1 test, TestInterface @interface)
    {
        Test1 test1 = new();
        _test = test;
        _interface = @interface;
        //test1.InternalProperty = "";
    }

    public void Test()
    {
        _interface.Method();
        Console.WriteLine(_test.PublicProperty);
        //_test = new Test1();
    }
}

public class Class2
{
    Class1 class1;
    public Class2()
    {        
        //class1 = new(new Test1()); 
        //class1._test
    }
}

public interface TestInterface
{
    void Method();
}
