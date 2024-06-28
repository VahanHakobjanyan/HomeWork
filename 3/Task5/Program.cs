namespace Task5
{
    internal class Program
    {
        //Task 5: Use Casting to cast each data type to another data types
        static void Main(string[] args)
        {
            byte var1 = 15;

            //byte to bool gives error
            //Console.WriteLine("{0} to bool equals {1}", var1, (bool)var1);

            Console.WriteLine("{0} to sbyte equals {1}", var1, (sbyte)var1);

            Console.WriteLine("{0} to char equals {1}", var1, (char)var1);

            Console.WriteLine("{0} to decimal equals {1}", var1, (decimal)var1);

            Console.WriteLine("{0} to double equals {1}", var1, (double)var1);

            Console.WriteLine("{0} to float equals {1}", var1, (float)var1);

            Console.WriteLine("{0} to int equals {1}", var1, (int)var1);

            Console.WriteLine("{0} to uint equals {1}", var1, (uint)var1);

            Console.WriteLine("{0} to long equals {1}", var1, (long)var1);

            Console.WriteLine("{0} to ulong equals {1}", var1, (ulong)var1);

            Console.WriteLine("{0} to short equals {1}", var1, (short)var1);

            Console.WriteLine("{0} to ushort equals {1}", var1, (ushort)var1);

            //byte to string gives error
            //Console.WriteLine("{0} to string equals {1}", var1, (string)var1);

            char var2 = 'y';

            //char to bool gives error
            //Console.WriteLine("{0} to bool equals {1}", var1, (bool)var1);
            //Console.WriteLine("{0} to bool equals {1}", var2, (bool)var2);

            Console.WriteLine("{0} to byte equals {1}", var1, (byte)var1);
            Console.WriteLine("{0} to byte equals {1}", var2, (byte)var2);

            Console.WriteLine("{0} to sbyte equals {1}", var1, (sbyte)var1);
            Console.WriteLine("{0} to sbyte equals {1}", var2, (sbyte)var2);

            Console.WriteLine("{0} to decimal equals {1}", var1, (decimal)var1);
            Console.WriteLine("{0} to decimal equals {1}", var2, (decimal)var2);

            Console.WriteLine("{0} to double equals {1}", var1, (double)var1);
            Console.WriteLine("{0} to double equals {1}", var2, (double)var2);

            Console.WriteLine("{0} to float equals {1}", var1, (float)var1);
            Console.WriteLine("{0} to float equals {1}", var2, (float)var2);

            Console.WriteLine("{0} to int equals {1}", var1, (int)var1);
            Console.WriteLine("{0} to int equals {1}", var2, (int)var2);

            Console.WriteLine("{0} to uint equals {1}", var1, (uint)var1);
            Console.WriteLine("{0} to uint equals {1}", var2, (uint)var2);

            Console.WriteLine("{0} to long equals {1}", var1, (long)var1);
            Console.WriteLine("{0} to long equals {1}", var2, (long)var2);

            Console.WriteLine("{0} to ulong equals {1}", var1, (ulong)var1);
            Console.WriteLine("{0} to ulong equals {1}", var2, (ulong)var2);

            Console.WriteLine("{0} to short equals {1}", var1, (short)var1);
            Console.WriteLine("{0} to short equals {1}", var2, (short)var2);

            Console.WriteLine("{0} to ushort equals {1}", var1, (ushort)var1);
            Console.WriteLine("{0} to ushort equals {1}", var2, (ushort)var2);

            //char to string gives error
            //Console.WriteLine("{0} to string equals {1}", var1, (string)var1;

            decimal var3 = 98.1m;

            //decimal to bool gives error
            //Console.WriteLine("{0} to bool equals {1}", var1, (bool)var1);

            Console.WriteLine("{0} to byte equals {1}", var1, (byte)var3);

            Console.WriteLine("{0} to sbyte equals {1}", var1, (sbyte)var3);

            Console.WriteLine("{0} to double equals {1}", var1, (double)var3);

            Console.WriteLine("{0} to float equals {1}", var1, (float)var3);

            Console.WriteLine("{0} to int equals {1}", var1, (int)var3);

            Console.WriteLine("{0} to uint equals {1}", var1, (uint)var3);

            Console.WriteLine("{0} to long equals {1}", var1, (long)var3);

            Console.WriteLine("{0} to ulong equals {1}", var1, (ulong)var3);

            Console.WriteLine("{0} to short equals {1}", var1, (short)var3);

            Console.WriteLine("{0} to ushort equals {1}", var1, (ushort)var3);

            Console.WriteLine("{0} to char equals {1}", var1, (char)var3);

            //decimal to string gives error
            //Console.WriteLine("{0} to string equals {1}", var1, (string)var1);

            Console.ReadKey();
        }
    }
}
