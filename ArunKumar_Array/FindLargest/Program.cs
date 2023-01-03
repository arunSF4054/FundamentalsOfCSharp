//using Internal;
using System;
namespace FindLargest;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the First number=");
        int number1=int.Parse(Console.ReadLine());
        Console.Write("Enter the Second number=");
        int number2=int.Parse(Console.ReadLine());
        Console.Write("Enter the Third Number=");
        int number3=int.Parse(Console.ReadLine());
        if(number1>number2 && number1>number2)
        {
            Console.WriteLine("Greatest of above  Three number is {0}",number1);
        }
        else if(number2>number1 && number2>number3)
        {
            Console.WriteLine("Greatest of above Three number is {0}",number2);
        }
        else
        {
          Console.WriteLine("Greatest of above Three number is {0}",number3);  
        }
    }
}