namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 4, 11 };

            var myList = new CustomList<int>(ints);

            myList.Remove(4);

            myList.Insert(3, 2);

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
