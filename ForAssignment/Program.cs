using System;
namespace ForAssignment;
class Program
{
    public static void Main(string[] args)
    {
        int[] array=new int[10];
        int temp=0;
        Console.WriteLine("Enter the 10 Numbers= ");
        for(int i=0;i<10;i++)
        {
            array[i]=int.Parse(Console.ReadLine());
            temp+=array[i];
            
            
        }
        Console.WriteLine("Sum of 10 Numbers="+temp);
        Console.WriteLine("Average Of 10 Numbers="+temp/10);
    }
}