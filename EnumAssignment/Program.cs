using System.Linq.Expressions;
using System;
namespace EnumAssignment;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number1=");
        int number1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number2=");
        int number2=int.Parse(Console.ReadLine());
        Console.WriteLine("\tMenu");
        Console.WriteLine("\t1.Addition\n\t2.Subtraction\n\t3.Multiply\n\t4.Division\n");
        Console.WriteLine("Enter your choice=");
        int choice=int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                Console.WriteLine($"Addition of Two Numbers {number1+number2}");
                break;
            }
             case 2:
            {
                Console.WriteLine($"Subtraction of two numbers {number1-number2}");
                break;
            }
             case 3:
            {
                Console.WriteLine($"Multiplication of two Numbers {number1*number2}");
                break;
            }
             case 4:
            {
                Console.WriteLine($"Division of two numbers {number1/number2}");
                break;
            }

        }

        
    }
}