using System.Runtime.CompilerServices;

namespace MemberwiseClone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("John", 28, new Eye());
            Person person2 = person1.MemberwiseCopy();

            person1.PrintPerson();
            person2.PrintPerson();

            Console.WriteLine(ReferenceEquals(person1.Eye, person2.Eye));
        }
    }
}
 