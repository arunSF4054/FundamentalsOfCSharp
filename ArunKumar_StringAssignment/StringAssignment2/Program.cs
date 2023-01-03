using System;
namespace StringAssignment2;
class Program
{
    public static void Main(string[] args)
    {
        string FirstString="chennai,Madurai,Trichy,Mumbai";
        string[] arrayString=FirstString.Split(",");
        foreach(string word in arrayString)
        {
            Console.WriteLine(word);
        }
    }
}