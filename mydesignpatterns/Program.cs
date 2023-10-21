
Console.WriteLine("Hello, World!");

var doSomething1 = DoSomethingSingletonPattern.Instance;
var doSomething2 = DoSomethingSingletonPattern.Instance;

doSomething1.MyInt = 1;
doSomething2.MyInt = 2;

Console.WriteLine(doSomething1 == doSomething2); // if this is true, then it is a singleton
Console.WriteLine(doSomething1.MyInt == doSomething2.MyInt); // if this is true, then it is a singleton

Console.WriteLine("Press any key to exit");


public class DoSomethingSingletonPattern
{
    private static DoSomethingSingletonPattern _instance;
    public static DoSomethingSingletonPattern Instance { get 
        { 
            if(_instance == null)
            {
                _instance = new DoSomethingSingletonPattern();
            }
            return _instance; 
        } 
    }
    protected DoSomethingSingletonPattern()
    {
    }
    public int MyInt { get; set; }
    public string MyString { get; set; }
}

