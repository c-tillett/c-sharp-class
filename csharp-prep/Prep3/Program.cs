using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is the magic number?");
        Random rng = new Random();

        int magic_number = rng.Next(100);

        int correct = 0;
        while (correct == 0)
        {
            Console.WriteLine("Guess the magic number! I'll tell you if you need to guess higher or lower.");
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