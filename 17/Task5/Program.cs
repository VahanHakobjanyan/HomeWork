namespace Task5
{
    internal class Program
    {
        //Define a delegate that takes an integer and returns a boolean.
        //Create a method that takes a list of integers and a delegate, and returns a list of integers that satisfy the delegate condition.
        //Implement a couple of delegates to filter even and odd numbers.

        delegate bool FilterCondition(int number);

        static void Main(string[] args)
        {
            FilterCondition even = delegate (int number)
            {
                return number % 2 == 0;
            };

            FilterCondition odd = delegate (int number)
            {
                return number % 2 == 1;
            };

            List<int> unfilteredlist = new List<int> { 2, 3, 10, 11, 12, };

            List<int> evenList = Filter(unfilteredlist, even);
            List<int> oddList = Filter(unfilteredlist, odd);

            foreach (int number in evenList)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("--------------------------------------------");

            foreach (int number in oddList)
            {
                Console.WriteLine(number);
            }
        }

        static List<int> Filter(List<int> list, FilterCondition condition)
        {
            List<int> filteredList = new List<int>();
            foreach (int number in list)
            {
                if (condition(number))
                {
                    filteredList.Add(number);
                }
            }

            return filteredList;
        }
    }
}
