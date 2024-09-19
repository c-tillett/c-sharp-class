using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        Console.Write("");
        string first_name = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        Console.Write("");
        string last_name = Console.ReadLine();
        
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}");
    }
}