using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // List<string> groceries = new List<string>();
        // string input = "";
        // int running = 0;
        
        // while (running == 0)
        // {
        //     Console.WriteLine("Add an item to your grocery list, or type 'done' to finish");
        //     input = Console.ReadLine();

        //     if (input == "done")
        //     {
        //         running = 1;
        //     }
        //     else
        //     {
        //         groceries.Add(input);
        //     }
            
            
           
        // }
        
        // Console.WriteLine($"Your grocery list is {groceries.Count} items long:");
        
        // foreach (string item in groceries)
        // {
        //     string correctItem = item.ToUpper();
        //     Console.WriteLine($"* {correctItem}");
        // }
        Console.WriteLine("What is your comment?");
        string comment = Console.ReadLine();
        Console.WriteLine($"Your comment is {comment}");
    }

}