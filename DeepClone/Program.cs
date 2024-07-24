namespace DeepClone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("John", 25, new Eye());
            Person person2 = person1.DeepCopy();

            person1.PrintPerson();
            person2.PrintPerson();

            Console.WriteLine(ReferenceEquals(person1.Eye, person2.Eye));
        }
    }
}
