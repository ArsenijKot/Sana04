using System;

class Currency
{
    public string CurrencyName { get; set; }
    public double ExchangeRateToUAH { get; set; }

    public Currency(string currencyName, double exchangeRateToUAH)
    {
        CurrencyName = currencyName;
        ExchangeRateToUAH = exchangeRateToUAH;
    }
}

class Product
{
    protected string Name;
    protected double Price;
    protected Currency Cost;
    protected int Quantity;
    protected string Producer;
    protected double Weight;

    public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
    {
        Name = name;
        Price = price;
        Cost = cost;
        Quantity = quantity;
        Producer = producer;
        Weight = weight;
    }

    public double GetPriceInUAH()
    {
        return Price * Cost.ExchangeRateToUAH;
    }

    public double GetTotalPriceInUAH()
    {
        return GetPriceInUAH() * Quantity;
    }

    public double GetTotalWeight()
    {
        return Weight * Quantity;
    }

    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product Name: {Name}");
        Console.WriteLine($"Price per unit: {Price} {Cost.CurrencyName} (equivalent to {GetPriceInUAH()} UAH)");
        Console.WriteLine($"Total quantity: {Quantity}");
        Console.WriteLine($"Producer: {Producer}");
        Console.WriteLine($"Weight per unit: {Weight} kg");
        Console.WriteLine($"Total weight: {GetTotalWeight()} kg");
        Console.WriteLine($"Total price: {GetTotalPriceInUAH()} UAH");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter currency name: ");
        string currencyName = Console.ReadLine();

        Console.Write("Enter exchange rate to UAH: ");
        double exchangeRateToUAH = double.Parse(Console.ReadLine());

        Currency currency = new Currency(currencyName, exchangeRateToUAH);

        Console.Write("Enter product name: ");
        string productName = Console.ReadLine();

        Console.Write("Enter price per unit: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter quantity in stock: ");
        int quantity = int.Parse(Console.ReadLine());

        Console.Write("Enter producer name: ");
        string producer = Console.ReadLine();

        Console.Write("Enter weight per unit (in kg): ");
        double weight = double.Parse(Console.ReadLine());

        Product product = new Product(productName, price, currency, quantity, producer, weight);

        Console.WriteLine("\nProduct Information:");
        product.DisplayProductInfo();
    }
}
