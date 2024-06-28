namespace Task4
{
    internal class Program
    {
        //Task 4: Check Palindrome
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to check palindrome or not");
            string strToCheck = Console.ReadLine();
            bool isPalindrome = false;

            for (int i = 0; i < strToCheck.Length / 2; i++)
            {
                if (strToCheck[i] != strToCheck[strToCheck.Length - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
                isPalindrome = true;
            }

            if (isPalindrome)
                Console.WriteLine("String is palindrome");
            else
                Console.WriteLine("String is not palindrome");

            Console.ReadKey();
        }
    }
}
