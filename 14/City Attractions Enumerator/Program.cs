using System.Reflection.Metadata;

namespace City_Attractions_Enumerator
{
    internal class Program
    {
        //Write a C# program that demonstrates the usage of your CityAttractions class.
        //Add a few attractions to the list(e.g., “Central Park,” “Metropolitan Museum of Art,” “Times Square”).
        //Iterate through the attractions and print their names and descriptions.
        //Bonus:
        //Implement a custom enumerator (class) that adheres to the IEnumerator<Attraction> interface.
        //Handle edge cases(e.g., resetting the enumerator).
        static void Main(string[] args)
        {
            Attraction att1 = new Attraction("Central Park", "Beautiful and green park", "Park");
            Attraction att2 = new Attraction("Metropolitan Museum of Art", "Home for history  pieces", "Museum");
            Attraction att3 = new Attraction("Times Square", "Richest street in the world", "street");

            CityAttractions attractions = new CityAttractions();

            attractions.AddAttraction(att1);
            attractions.AddAttraction(att2);
            attractions.AddAttraction(att3);

            foreach (var att in attractions)
            {
                Console.WriteLine(att);
            }
        }
    }
}
