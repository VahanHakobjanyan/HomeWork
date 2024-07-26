using System.Xml;

namespace Task2
{
    internal class Program
    {
        //Task 2: Define an abstract class Animal:
        //Create an abstract class called Animal with an abstract method MakeSound().
        //Derive classes like Dog, Cat, and Bird from Animal.
        //Implement the MakeSound() method in each derived class to produce the unique sound of each animal.
        static void Main(string[] args)
        {
            Animal[] animals = { new Dog(), new Cat(), new Bird() };

            foreach (var animal in animals)
            {
                animal.MakeSound();
            }

            Console.ReadKey();
        }
    }
}
