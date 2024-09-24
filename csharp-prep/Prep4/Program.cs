using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter one number at a time by typing the number and pressing enter.");
        Console.WriteLine("To stop entering numbers, please type the number 0 and press enter.");
        string input_string = "1";
        int input_num = 0;
        int looping = 1;
        List<int> numbers = new List<int>();

        while (looping == 1)
        {
            Console.WriteLine("Please add a number o the list, or enter 0 to stop:");
            input_string = Console.ReadLine();
            input_num = int.Parse(input_string);

            if (input_num == 0)
            {
                looping = 0;
            }
            else
            {
                numbers.Add(input_num);
            }
        }
        int sum = 0;
        int largest = 0;
        foreach (int number in numbers)
        {
            sum = sum + number;
        }
        
        float avg = sum / numbers.Count;

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
    
        Console.WriteLine($"The sum of the list is {sum}");
        Console.WriteLine($"The average of the list is {avg}");
        Console.WriteLine($"The largest number is {largest}");

    }
}