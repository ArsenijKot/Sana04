using System;

class MyDate
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public int Hour { get; set; }
    public int Minute { get; set; }

    public MyDate(int day, int month, int year, int hour, int minute)
    {
        Day = day;
        Month = month;
        Year = year;
        Hour = hour;
        Minute = minute;
    }

    public int ToMinutes()
    {
        DateTime dateTime = new DateTime(Year, Month, Day, Hour, Minute, 0);
        return (int)(dateTime - new DateTime(1970, 1, 1)).TotalMinutes;
    }
}

class Airplane
{
    protected string StartCity;
    protected string FinishCity;
    protected MyDate StartDate;
    protected MyDate FinishDate;

    public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
    {
        StartCity = startCity;
        FinishCity = finishCity;
        StartDate = startDate;
        FinishDate = finishDate;
    }

    public int GetTotalTime()
    {
        return FinishDate.ToMinutes() - StartDate.ToMinutes();
    }

    public bool IsArrivingToday()
    {
        return StartDate.Day == FinishDate.Day && StartDate.Month == FinishDate.Month && StartDate.Year == FinishDate.Year;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the start city: ");
        string startCity = Console.ReadLine();

        Console.Write("Enter the finish city: ");
        string finishCity = Console.ReadLine();

        Console.WriteLine("Enter the start date and time (DD MM YYYY HH MM):");
        int startDay = int.Parse(Console.ReadLine());
        int startMonth = int.Parse(Console.ReadLine());
        int startYear = int.Parse(Console.ReadLine());
        int startHour = int.Parse(Console.ReadLine());
        int startMinute = int.Parse(Console.ReadLine());
        MyDate startDate = new MyDate(startDay, startMonth, startYear, startHour, startMinute);

        Console.WriteLine("Enter the finish date and time (DD MM YYYY HH MM):");
        int finishDay = int.Parse(Console.ReadLine());
        int finishMonth = int.Parse(Console.ReadLine());
        int finishYear = int.Parse(Console.ReadLine());
        int finishHour = int.Parse(Console.ReadLine());
        int finishMinute = int.Parse(Console.ReadLine());
        MyDate finishDate = new MyDate(finishDay, finishMonth, finishYear, finishHour, finishMinute);

        Airplane airplane = new Airplane(startCity, finishCity, startDate, finishDate);

        Console.WriteLine("\nTotal travel time (in minutes): " + airplane.GetTotalTime());
        Console.WriteLine("Is arriving today? " + (airplane.IsArrivingToday() ? "Yes" : "No"));
    }
}

