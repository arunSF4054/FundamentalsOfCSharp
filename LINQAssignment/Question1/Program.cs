using System.Collections;
using System.Data;
using System;
using System.Linq;
using System.Collections.Generic;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
       
        string[] array={"USA","ABUDHABI","AMSTERDAM","ROME","MADURAI","LONDON","NEWDELHI","MUMBAI"};
        
       
       
        IEnumerable<string> data= from str in array
                      where (str.StartsWith('M') && str.EndsWith('I'))
                      select str;

        
             
             foreach(string st in data)
             {
                Console.WriteLine(st);
             }


             
    
        
    }
}