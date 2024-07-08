namespace Custom_Currency_Exchange_Rate
{
    internal class Program
    {
        //Custom Currency Exchange Rate: Create a CurrencyExchangeRate struct to store exchange rates between different currencies.

        static void Main(string[] args)
        {
            
        }
    }

    struct CurrencyExchangeRate
    {
        public decimal Amd { get; }
        public decimal Rub { get; }
        public decimal Usd { get; }
        public decimal Eur { get; }

        public CurrencyExchangeRate()
        {
            Amd = 1m;
            Rub = 4.20m;
            Usd = 385m;
            Eur = 410;
        }
        public CurrencyExchangeRate(decimal amd, decimal rub, decimal usd, decimal eur)
        {
            Amd = amd;
            Rub = rub;
            Usd = usd;
            Eur = eur;
        }
    }
}
