namespace GetPersonInfo
{
    internal class Program
    {
        //Task11: Write a method called GetPersonInfo that takes a person’s name and age as input and returns
        //a tuple containing their name, age, and a boolean indicating whether they are an adult (age >= 18).
        static void Main(string[] args)
        {
            (string n, int age, bool isAdult) person;

            person = GetPersonsInfo("John", 17);

            Console.WriteLine($"{person.n} is {person.age} years old. Is he/she adult - {person.isAdult}");
        }

        static (string name, int age, bool IsAdult) GetPersonsInfo(string name, int age)
        {
            bool isAdult = age >= 18 ? true : false;
            return (name, age, isAdult);
        }
    }
}
