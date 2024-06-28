namespace Anagramm_Strings
{
    internal class Program
    {
        //Task9: Anagram Or Not
        static void Main(string[] args)
        {
            string str1 = "angel";
            string str2 = "glean";

            Console.WriteLine(isAnagram(str1, str2));
        }

        static bool isAnagram(string str1, string str2)
        {

            char[] sortedStr1 = str1.ToCharArray();
            Array.Sort(sortedStr1);
            char[] sortedStr2 = str2.ToCharArray();
            Array.Sort(sortedStr2);

            for (int i = 0; i < sortedStr1.Length; i++)
            {
                if (sortedStr1[i] != sortedStr2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
