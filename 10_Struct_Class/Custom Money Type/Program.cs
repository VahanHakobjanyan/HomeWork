namespace Custom_Money_Type
{
    internal class Program
    {
        //Custom Money Type: Create a Money struct to represent currency amounts (e.g., USD, EUR).
        //Include methods for addition and subtraction.

        static void Main(string[] args)
        {
            Money money = new Money();
            money.Amount = 100;
            Console.WriteLine(money.Amount);

            money.Addition(35);
            Console.WriteLine(money.Amount);

            money.Substraction(35);
            Console.WriteLine(money.Amount);
        }
    }

    struct Money
    {
        public decimal Amount { get; set; }

        public void Addition(decimal amount)
        {
            Amount += amount;
        }
        public void Substraction(decimal amount)
        {
            Amount -= amount;
        }
    }
}
