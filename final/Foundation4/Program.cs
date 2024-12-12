using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("Running", "September 21, 2024", 75, 10);
        Biking biking = new Biking("Biking", "December 1, 2024", 15, 10.1);
        Swimming swimming = new Swimming("Swimming", "July 4, 2024", 60, 10);

        running.PrintSummary();
        Console.WriteLine();
        biking.PrintSummary();
        Console.WriteLine();
        swimming.PrintSummary();
    }
}