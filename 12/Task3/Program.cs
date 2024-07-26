namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Motorcycle moto = new Motorcycle();
            Vehicle vehicle = new Vehicle();

            //Upcast happens implicitly

            vehicle = car;
            vehicle = moto;

            //downcast need to be done explicitly

            //car = vehicle;
            //moto = vehicle;

            //Solution either do explicitly or override conversion

            car = (Car)vehicle;
            moto = vehicle as Motorcycle;
        }
    }
}
