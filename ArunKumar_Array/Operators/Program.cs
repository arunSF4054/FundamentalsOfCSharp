using System;
namespace Operators;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the First Number=");
        int number1=int.Parse(Console.ReadLine());
        Console.Write("Enter the Second Number=");
        int number2=int.Parse(Console.ReadLine());
        int addition=number1+number2;
        double subtraction=number1-number2;
        int Multiplication=number1*number2;
        double division=number1*number2;
        double modulo=number1%number2;
        Console.WriteLine("\nAddition of {0} and {1} is {2}",number1,number2,addition);
        Console.WriteLine("\nSubtraction {0} and {1} is {2}",number1,number2,subtraction);
        Console.WriteLine("\nMultiplication {0} and {1} is {2}",number1,number2,Multiplication);
        Console.WriteLine("\nDivision {0} and {1} is {2}",number1,number2,division);
        Console.WriteLine("\nModulo {0} and {1} is {2}",number1,number2,modulo);

    }
}