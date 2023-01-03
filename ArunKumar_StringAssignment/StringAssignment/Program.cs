using System;
namespace StringAssignment;
class Program
{
    public static void Main(string[] args)
    {
        string NewString="Syncfusion";
        int i=0;
        Console.WriteLine("The Odd characters in the string:");
        while(i<NewString.Length)
        {
            Console.WriteLine(NewString[i]);
            i+=2;

        }
        string UpdatedString=NewString.Replace('n','N');
        Console.WriteLine("Updated String is ="+UpdatedString);
        Console.WriteLine("Reverse Order");
        for(i=UpdatedString.Length-1;i>=0;i--)
        {
            Console.WriteLine(UpdatedString[i]);
        }
        int n=UpdatedString.Length;
        Console.WriteLine("The length of the string is="+n);
        Console.WriteLine("Enter the first string =");
        string firstString=Console.ReadLine();
        Console.WriteLine("Enter the second string =");
        string secondString=Console.ReadLine();
        firstString=firstString.Remove(4);
        secondString=secondString.Remove(0,4);
        Console.WriteLine(firstString+secondString);

    }
}