using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();

        string name = GetName();
        int favorite_number = GetNumber();
        int number_squared = SquareNumber(favorite_number);
        PrintResults(name, number_squared);

    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string GetName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        return name;
    }

    static int GetNumber()
    {
        Console.WriteLine("What is your favorite number?");
        string number_string = Console.ReadLine();
        int number = int.Parse(number_string);

        return number;
    }

    static int SquareNumber(int favorite_number)
    {
       int squared_number = favorite_number * favorite_number;

       return squared_number;
    }

    static void PrintResults(string name, int number)
    {
        Console.WriteLine($"Hello {name}!");
        Console.WriteLine($"Did you know that the square of your favorite number is {number}?");
    }

}