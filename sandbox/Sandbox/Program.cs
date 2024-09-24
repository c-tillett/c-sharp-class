using System;
using System.Diagnostics;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the first number:");
        string first_number = Console.ReadLine();
        int number_one = int.Parse(first_number);

        Console.WriteLine("Please enter the second number:");
        string second_number = Console.ReadLine();
        int number_two = int.Parse(second_number);
        
        Console.WriteLine("1 = +, 2 = -, 3 = *, and 4 = /");
        Console.WriteLine("What operation would you like to preform?");
        string operation = Console.ReadLine();
        float operater = int.Parse(operation);

        if (operater == 1)
        {
            int answer = number_one + number_two;
            Console.WriteLine($"{number_one} plus {number_two} is {answer}");
        }

        else if (operater == 2)
        {
            int answer = number_one - number_two;
            Console.WriteLine($"{number_one} minus {number_two} is {answer}");
        }

        else if (operater == 3)
        {
            int answer = number_one * number_two;
            Console.WriteLine($"{number_one} times {number_two} is {answer}");
        }

        else if (operater == 4)
        {
            float answer = number_one / number_two;
            Console.WriteLine($"{number_one} divided by {number_two} is {answer}");
        }

        else
        {
            Console.WriteLine("You didn't enter a valid operation! Try running the program again...I didn't want to write a loop.");
        }
    }
}