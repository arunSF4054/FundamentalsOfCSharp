using System;
namespace ExceptionHandling;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Number1=");
        int number1=int.Parse(Console.ReadLine());
         Console.WriteLine("Enter the Number2=");
        int number2=int.Parse(Console.ReadLine());
        try
        {
            double number3=number1/number2;
            Console.WriteLine("Division of two numbers="+number3);

        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Please enter the valid number for division");

        }
    }
}