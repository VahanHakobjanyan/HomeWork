using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;

namespace Traveling_by_Train_Stops
{
    internal class Program
    {
        //Consider a train route with multiple stops (attractions).
        //IEnumerable is your train ticket, allowing you to travel from one stop to the next.
        //At each station (iteration), you explore the surroundings (access details) without knowing the entire route upfront.

        static void Main(string[] args)
        {
            Ticket ticket = new Ticket();

            ticket.AddStopsToTicket(new Stop("station1", Cities.Yerevan));
            ticket.AddStopsToTicket(new Stop("station2", Cities.Sisian));
            ticket.AddStopsToTicket(new Stop("station1", Cities.Gyumri));

            foreach (Stop stop in ticket)
            {
                Console.WriteLine(stop);
            }
        }
    }
}
