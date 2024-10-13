using System;
using System.IO;
using System.IO.Enumeration;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;
        while (running == true)
        {
            Console.WriteLine("Please input a number curresponding to one of the following choices:");
            Console.WriteLine("1 - Enter a journal entry");
            Console.WriteLine("2 - Display journal");
            Console.WriteLine("3 - Load journal");
            Console.WriteLine("4 - Save journal");
            Console.WriteLine("5 - Exit program");

            int decision = int.Parse(Console.ReadLine());

            if (decision == 1)
            {
                journal.NewEntry();
            }
            else if (decision == 2)
            {
                journal.PrintEntries();
            }
            else if (decision == 3)
            {
                Console.WriteLine("What is the name of the file that you would like to load?");
                string file = Console.ReadLine();
                journal.LoadFile(file);
            }
            else if (decision == 4)
            {
                Console.WriteLine("What is the name of the file that you would like to save to?");
                string file = Console.ReadLine();
                journal.SaveFile(file);
            }
            else if (decision == 5)
            {
                running = false;
            }
            else
            {
                Console.WriteLine("That is not a valid option, please try again.");
            }

        }
    }
}