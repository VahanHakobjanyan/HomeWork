using Zoo_Animals.Animals;

namespace Zoo_Animals
{
    internal class Program
    {
        //At a zoo, each enclosure holds different animals (attractions).
        //IEnumerable acts like a zookeeper who introduces you to one animal at a time(using an IEnumerator).
        //You observe each animal(access its properties) without overcrowding the entire zoo.
        static void Main(string[] args)
        {
            Enclosure dogEnclosure = new Enclosure(AnimalType.Dog);
            dogEnclosure.AddAnimal(new Dog(5));
            dogEnclosure.AddAnimal(new Dog(3));
            dogEnclosure.AddAnimal(new Dog(1));
            dogEnclosure.AddAnimal(new Cat(2));
            dogEnclosure.AddAnimal(new Dog(4));

            foreach(var animal in dogEnclosure)
            {
                Console.WriteLine(animal);
            }

            Console.ReadKey();
        }
    }
}
