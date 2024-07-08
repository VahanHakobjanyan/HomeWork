namespace Geographical_Coordinates
{
    internal class Program
    {
        //Geographical Coordinates: Define a GeoLocation struct with latitude and longitude fields.
        //Use it to store coordinates for various cities

        static void Main(string[] args)
        {
            GeoLocation[] cities = new GeoLocation[5];

            cities[0] = new GeoLocation("Paris", 14, 66);
            cities[1] = new GeoLocation("Moscow", 18, 42);
            cities[2] = new GeoLocation("Rome", 54, 12);
            cities[3] = new GeoLocation("Sydney", 9, 82);
            cities[4] = new GeoLocation("Washington", 80, 30);
        }
    }

    struct GeoLocation
    {
        public string Name { get; init; }
        public double Latitude { get; init; }
        public double Longitude { get; init; }

        public GeoLocation(string name, double lat, double lon)
        {
            Name = name;
            Latitude = lat;
            Longitude = lon;
        }
    }
}
