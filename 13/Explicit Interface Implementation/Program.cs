namespace Explicit_Interface_Implementation
{
    internal class Program
    {
        //Define an interface IAnimal with methods Eat() and Sleep().
        //Create a class Dog that implements IAnimal.Implement the methods explicitly(using the IAnimal.prefix).
        //Create a Dog object and call the Eat() and Sleep() methods.

        static void Main(string[] args)
        {
            Dog dog = new Dog();

            //dog.Eat(); Error

            IAnimal animal = dog;
            animal.Eat();
            animal.Sleep();

            Console.ReadKey();
        }
    }
}
