using System.Diagnostics;

namespace Custom_Interface_properties
{
    internal class Program
    {
        //Custom Interface Properties:
        //Design an interface IStudent with properties Name, Age, and Grade.
        //Create a class Student that implements this interface.
        //Students should set values for these properties and retrieve them.

        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "John";
            student.Age = 20;
            student.Grade = 3;

            Console.WriteLine("Student - {0}, Age - {1}, Grade - {2}", student.Name, student.Age, student.Grade);

            Console.ReadKey();
        }
    }
}
