using System;

class MyDate
{
    protected int Year { get; set; }
    protected int Month { get; set; }
    protected int Day { get; set; }
    protected int Hours { get; set; }
    protected int Minutes { get; set; }

    public MyDate(int year, int month, int day, int hours, int minutes)
    {
        Year = year;
        Month = month;
        Day = day;
        Hours = hours;
        Minutes = minutes;
    }

    public void DisplayDateTime()
    {
        Console.WriteLine($"Date and Time: {Day}/{Month}/{Year} {Hours}:{Minutes:D2}");
    }

    public void AddMinutes(int minutesToAdd)
    {
        DateTime dateTime = new DateTime(Year, Month, Day, Hours, Minutes, 0);
        dateTime = dateTime.AddMinutes(minutesToAdd);
        Year = dateTime.Year;
        Month = dateTime.Month;
        Day = dateTime.Day;
        Hours = dateTime.Hour;
        Minutes = dateTime.Minute;
    }

    public bool IsEqualTo(MyDate other)
    {
        return Year == other.Year && Month == other.Month && Day == other.Day &&
               Hours == other.Hours && Minutes == other.Minutes;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine());

        Console.Write("Enter the month: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter the day: ");
        int day = int.Parse(Console.ReadLine());

        Console.Write("Enter the hours: ");
        int hours = int.Parse(Console.ReadLine());

        Console.Write("Enter the minutes: ");
        int minutes = int.Parse(Console.ReadLine());

        MyDate date1 = new MyDate(year, month, day, hours, minutes);

        Console.WriteLine("\nInitial Date and Time:");
        date1.DisplayDateTime();

        Console.Write("\nEnter the number of minutes to add: ");
        int minutesToAdd = int.Parse(Console.ReadLine());

        date1.AddMinutes(minutesToAdd);

        Console.WriteLine("\nUpdated Date and Time:");
        date1.DisplayDateTime();

        Console.WriteLine("\nEnter another date to compare:");

        Console.Write("Enter the year: ");
        int year2 = int.Parse(Console.ReadLine());
        Console.Write("Enter the month: ");
        int month2 = int.Parse(Console.ReadLine());
        Console.Write("Enter the day: ");
        int day2 = int.Parse(Console.ReadLine());
        Console.Write("Enter the hours: ");
        int hours2 = int.Parse(Console.ReadLine());
        Console.Write("Enter the minutes: ");
        int minutes2 = int.Parse(Console.ReadLine());

        MyDate date2 = new MyDate(year2, month2, day2, hours2, minutes2);

        if (date1.IsEqualTo(date2))
        {
            Console.WriteLine("\nDates are equal.");
        }
        else
        {
            Console.WriteLine("\nDates are not equal.");
        }
    }
}
