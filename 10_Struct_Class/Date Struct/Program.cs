using System.Runtime.CompilerServices;

namespace Date_Struct
{
    internal class Program
    {
        //Date Struct: Design a struct called MyDate with fields for day, month, and year. Implement methods to:
        //Validate whether the date is valid(e.g., no negative values, valid month, etc.).
        //Calculate the next day(consider leap years).
        static void Main(string[] args)
        {
            MyDate date = new MyDate();
            date.day = 30;
            date.year = 1998;
            date.month = 6;

            Console.WriteLine(date.IsValid(date));

            Console.ReadKey();
        }
    }

    struct MyDate
    {
        public byte day { get; set; }
        public byte month { get; set; }
        public int year { get; set; }

        public bool IsValid(MyDate date)
        {
            bool isValid = false;
            DateTime tempDate;

            string dateString = String.Join("/", month.ToString(), day.ToString(), year.ToString());
            isValid = DateTime.TryParse(dateString, out tempDate);
            return isValid;
        }
    }
}
