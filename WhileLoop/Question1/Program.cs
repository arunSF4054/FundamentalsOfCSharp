using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        string choice="y";
        while(choice=="y")
        {
            Console.WriteLine("Which one is a capital of India?");
            Console.WriteLine("\t1.Mumbai\n\t2.Delhi\n\t3.Chennai\n\t4.Kolkata");
            Console.Write("\nPlease enter the choice=");
            int option=int .Parse(Console.ReadLine());
            if(option==2)
            {
                Console.WriteLine("Correct Answer");
            }
            else
            {
                Console.WriteLine("Incorrect Answer");
            }
            Console.WriteLine("Press Y to Continue or press N to Close");
            choice=Console.ReadLine().ToLower();
        }
    }
}