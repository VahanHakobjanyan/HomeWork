namespace Instance_creation_and_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Error.Cannot create instance from abstract class
            //Class1 class1 = new Class1();

            //Error.Cannot create instance from interface
            //Iinterface1 interface1 = new Iinterface1();
        }
    }

    abstract class Class1
    {
        //Abstract classes have constructor(s)
        public Class1() { }
    }

    interface Iinterface1
    {
        //Error.Interface cannot have constructor
        //public Iinterface1();
    }
}
