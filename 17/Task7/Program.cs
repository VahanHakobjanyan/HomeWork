using System.Collections.Generic;

namespace Task7
{
    internal class Program
    {
        //Define a delegate that takes two integers and returns a boolean.
        //Create a method that sorts a list of integers based on the delegate.
        //Implement delegates for ascending and descending order.

        delegate bool Filter(int current, int next);

        static void Main(string[] args)
        {
            Filter ascending = (current, next) => current > next;
            Filter descending = (current, next) => current < next;

            List<int> ints = new List<int> { 1, 32, 2, 7, 5, 54 };

            List<int> ascendingInts = Sort(ints, ascending);
            foreach (int i in ascendingInts)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------------------------");

            List<int> descendingInts = Sort(ints, descending);
            foreach (int i in descendingInts)
            {
                Console.WriteLine(i);
            }
        }

        static List<int> Sort(List<int> list, Filter filter)
        {
            if (list == null) throw new ArgumentNullException("List is null here");
            if (filter == null) throw new ArgumentNullException("Filter is null here");

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (filter(list[j], list[j + 1]))
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
        }
    }
}
