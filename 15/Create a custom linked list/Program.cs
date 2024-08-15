namespace Create_a_custom_linked_list
{
    internal class Program
    {
        //Create a custom linked list using yield return.
        //Implement methods like Add, Remove, and Contains.
        //Example: var myList = new CustomLinkedList<int>(); myList.Add(10); myList.Add(20); myList.Add(30);.
        static void Main(string[] args)
        {
            CustomLinkedList<int> cus = new CustomLinkedList<int>();

            cus.Add(1);
            cus.Add(20);


            foreach (var i in cus)
            {
                Console.WriteLine(i);
            }
        }
    }
}
