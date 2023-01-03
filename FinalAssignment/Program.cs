using System.Security.AccessControl;
using System;
namespace FinalAssignment;
class Program
{
    public static void Main(string[] args)
    {
        
        Files.create();
        Files.ReadToCSV();
        //Operation.DefaultData();
        Operation.MainMenu();
        Files.WriteToCSV();
    }
}