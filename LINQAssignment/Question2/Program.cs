using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
       string[] array={"USA","ABUDHABI","AMSTERDAM","ROME","MADURAI","FRANCE","LONDON","NEWDELHI","MUMBAI","ITALY"};
        
       IEnumerable<string> data= from item in array
                                orderby item.Length
                                select item;

       Console.WriteLine("Sorting");
              foreach(string s in data)
             {
                Console.WriteLine(s);
             }                         
    }
}