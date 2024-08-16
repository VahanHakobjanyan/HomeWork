namespace Implementation_vs_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Class2 : Class1
    {
        //Not overriding abstract method will give error
        public override void AbstractMethod()
        {
            Console.WriteLine("Abstract method");
        }
    }

    class Class3 : Iinterface1
    {
        //Must implement all interface members which dont have default implementation
        public int A { get; set; }

        public void MethodWithoutImplementation()
        {
            Console.WriteLine("Mehtod without implementation");
        }

    }
    abstract class Class1
    {
        //Abstract classes can contain abstract methods for child classes to override
        public abstract void AbstractMethod();
        //Also can contain non abstract methods that child classes will inherit and can override or not
        public void JustAMethod()
        {
            Console.WriteLine("Regular method");
        }
        //Abstract classes are same in all Language versions
    }

    interface Iinterface1
    {
        //Depending on Language version (starting from version 8.0) interfaces can contain methods with default implementaion,
        //and properties. Cant have fields.
        public int A { get; set; }

        //Error.Cannot contain instance filed.
        //public int a;
        public void MethodWithoutImplementation();
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
