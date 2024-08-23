namespace CustomStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 1 };
            MyStack<int> myS = new MyStack<int>(arr);

            myS.Push(1);
            myS.Push(4);
            myS.Push(5);
            myS.Push(65);

            foreach (int i in myS)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------------------------------------");

            myS.Pop();

            foreach (int i in myS)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine(myS.Peek());

            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine(myS.Contains(0));
            Console.WriteLine(myS.Contains(5));

        }
    }
}
