namespace Task3
{
    internal class Program
    {
        //Task 3: String Interpolation
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string profession = Console.ReadLine();

            Console.WriteLine($"{name} {surname} is {age} years old and works as {profession}");

            Console.ReadKey();
        }
    }
}
