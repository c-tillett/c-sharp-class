using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("Running", "September 21, 2024", 75, 10);
        Biking biking = new Biking("Biking", "December 1, 2024", 15, 10.1);
        Swimming swimming = new Swimming("Swimming", "July 4, 2024", 10, 60);
        List<string> summaries = new List<string>{running.GetSummary(), biking.GetSummary(), swimming.GetSummary()};

        foreach (string summary in summaries)
        {
            Console.WriteLine($"{summary}");
            Console.WriteLine();
        }
    }
}