namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        }
    }
    //You can only inherit from one class
    abstract class Class1 : Class2
    { }

    //It is possible to implement from multiple interfaces at once.
    abstract class Class3 : Iinterface1, Iinterface2
    { }

    //Error. Cannot inherit from multiple classes

    //class Class4 : Class1, Class2
    //{ }
}

