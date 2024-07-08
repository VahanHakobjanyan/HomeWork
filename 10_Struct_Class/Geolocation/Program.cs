namespace Geolocation
{
    internal class Program
    {
        //Geolocation: Suppose you need to represent geographical coordinates (latitude and longitude). Generate using exaples

        static void Main(string[] args)
        {
            GeoLocation paris = new GeoLocation();
            paris.lat = 48;
            paris.lon = 2;
        }
    }

    struct GeoLocation
    {
        public int lat { get; set; }
        public int lon { get; set; }
    }
}
