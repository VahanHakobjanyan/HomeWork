namespace Task2
{
    internal class Program
    {
        //Task 2: String Concatenation
        static void Main(string[] args)
        {
            string str1 = "------- fgshiuohluf";
            string str2 = "fdskhjfsd";
            string str3 = "oyil;bniyugh";
            string str4 = "789ojmoi968k7i6tn";
            string str5 = "29873hvc45noqlry";

            string concatedStr = str1 + " " + str2 + " " + str3 + " " + str4 + " " + str5;

            Console.WriteLine("1.Concated string equals {0}", concatedStr);
            Console.WriteLine();

            //Another way
            string space = " ";
            concatedStr = string.Concat(str1, space, str2, space, str3, space, str4, space, str5);
            Console.WriteLine("2.Concated string equals {0}", concatedStr);
            Console.WriteLine();

            //Another way
            string[] strings = { str1, str2, str3, str4, str5 };
            concatedStr = string.Empty;

            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] += space;
                concatedStr += strings[i];
            }
            Console.WriteLine("3.Concated string equals {0}", concatedStr);

            Console.ReadKey();
        }
    }
}
