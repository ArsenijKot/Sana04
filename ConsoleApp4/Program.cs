using System;

namespace CurrencyExample
{
    class Currency
    {
        protected string Name;
        protected double ExRate;

        public Currency()
        {
            Name = "Unknown";
            ExRate = 0.0;
        }

        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(Currency other)
        {
            Name = other.Name;
            ExRate = other.ExRate;
        }

        public string NameProperty
        {
            get { return Name; }
            set { Name = value; }
        }

        public double ExRateProperty
        {
            get { return ExRate; }
            set { ExRate = value; }
        }

        public void DisplayCurrencyInfo()
        {
            Console.WriteLine($"Currency Name: {Name}");
            Console.WriteLine($"Exchange Rate: {ExRate} UAH per 1 unit of {Name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the currency name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the exchange rate (UAH per 1 unit of currency): ");
            double exRate = Convert.ToDouble(Console.ReadLine());

            Currency currency1 = new Currency(name, exRate);

            currency1.DisplayCurrencyInfo();

            Currency currency2 = new Currency(currency1);

            Console.WriteLine("\nCopied Currency Information:");
            currency2.DisplayCurrencyInfo();
        }
    }
}
