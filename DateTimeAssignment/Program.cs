using System;
namespace DateTimeAssignment;
class Program
{
    public static void Main(string[] args)
    {
        DateTime today=DateTime.Now;
        Console.WriteLine("Current month of the day");
        Console.WriteLine(today.Month);
        Console.WriteLine("\nPrevious of 3 days from today");
        DateTime NewDate=today.AddDays(-3);
        Console.WriteLine(NewDate.ToShortDateString());
        Console.WriteLine("\nCurrent Time");
        Console.WriteLine(today.ToString("hh-mm-ss tt"));
    }
}