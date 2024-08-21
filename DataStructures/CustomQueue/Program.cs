using System.Collections;

namespace CustomQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 4, 2, 84, 43 };
            var myQ = new MyQueue<int>(arr);

            Console.WriteLine("Whole queue");
            foreach (int i in myQ)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Whole queue after enquing 432");

            myQ.Enqueue(432);
            foreach (int i in myQ)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Dequeued item - {0}", myQ.Dequeue());
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("After dequing");
            foreach (int i in myQ)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("First in queue - {0}", myQ.Peek());

            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Contains 84 - {0}", myQ.Contains(84));
            Console.WriteLine("Contains 99 - {0}", myQ.Contains(99));

            Console.WriteLine("-----------------------------------------------------");

            myQ.Clear();
            Console.WriteLine("Queue is empty after clearing");
            foreach (int i in myQ)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
