using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine($"This program has 3 activities to help you with mindfulness. \n Please choose one of the following options by typing one of the numbers and then pressing the Enter Key.");
        int runs = 0;
        string input = "0";
        while (int.Parse(input) != 4)
        {
            Console.Clear();
            Console.WriteLine("Pelase select from the following:");
            Console.WriteLine("1) Breathing Activity");
            Console.WriteLine("2) Reflection Activity");
            Console.WriteLine("3) Listing Activity");
            Console.WriteLine();
            Console.WriteLine("4) Quit");
            Console.WriteLine();
            input = Console.ReadLine();

            if (int.Parse(input) == 1)
            {
                Console.WriteLine("For how many seconds would you like to do this activity for?\n");
                string duration = Console.ReadLine();
                Breathing activity = new Breathing(int.Parse(duration));
                activity.BreathingActivity();
                runs = runs + 1;
            }
            else if (int.Parse(input) == 2)
            {
                Console.WriteLine("For how many seconds would you like to do this activity for?\n");
                string duration = Console.ReadLine();
                Reflection activity = new Reflection(int.Parse(duration));
                activity.ReflectionActivity();
                runs = runs + 1;
            }
            else if (int.Parse(input) == 3)
            {
                Console.WriteLine("For how many seconds would you like to do this activity for?\n");
                string duration = Console.ReadLine();
                Listing activity = new Listing(int.Parse(duration));
                activity.ListingActivity();
                runs = runs + 1;
            }
            else if (int.Parse(input)==4)
            {
            }
            else
            {
                Console.Clear();
                Console.WriteLine("I'm sorry, but that option is not available. Please try again, inputing a number between 1 and 4");
            }
            
            string goodbye = "";
            if (runs > 1)
            {
                goodbye = $"Thank you for taking some time for yourself today! You completed {runs} actvities. See you again soon!";
            }
            else if (runs == 1)
            {
                goodbye = $"Thank you for taking some time for yourself today, even if it was just 1 short activity! See you again soon!";
            }
            else
            {
                goodbye = $"Thank you for considering your options! I hope to see you again soon!";
            }
            Console.WriteLine(goodbye);
        }
    }
}