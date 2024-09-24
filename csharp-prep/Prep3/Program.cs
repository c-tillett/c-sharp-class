using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is the magic number?");
        string magic_string = Console.ReadLine();
        int magic_number = int.Parse(magic_string);

        int correct = 0;
        while (correct == 0)
        {
            Console.WriteLine("What is your guess?");
            string guess_string = Console.ReadLine();
            int guess_num = int.Parse(guess_string);

            if (guess_num == magic_number)
            {
                correct = 1;
            }
            else if (guess_num > magic_number)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("Higher!");
            }
        }

        Console.WriteLine($"That's correct! The magic number is {magic_number}!");

    }
}