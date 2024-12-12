using System;

class Program
{
    static void Main(string[] args)
    {
        Address receptionAddress = new Address("Das Burger: Restaurant", "Main 32", "Wiesbaden", "Hessen", 83440, "Germany");
        Address lectureAddresss = new Address("The Hilton Deluxe Ultra", "Nothbywest East Ave.", "Bozeman", "Montana", 87761, "USA");
        Address outdoorAddress = new Address("Smith Park", "54 N 777777776 South", "Rexburg", "Idaho", 22153, "USA");

        Reception reception = new Reception("The Tillett's", "Join us at a legendary and historic restaraunt in Downtown Wiesbaden to celebrate Cory and Tiff's wedding", "April 20th, 2025", "5:00 PM", receptionAddress, "February 11, 2025", "ashortgeneration@msn.net");

        Lecture lecture = new Lecture("Fall Brawl", "Join us before a regional tournament to learn about the keys to success!", "September 22nd, 2025", "9:00 AM to 10:00 AM", lectureAddresss, "Dale 'LowTierGod' Wilson", 1155);

        Outdoor outdoor = new Outdoor("Winter Water Balloon Experiment", "Why let the cold stop us? Join us for a winter water balloon fight!", "January 3rd, 2025", "All day, 8:00 AM to 8:00 PM", outdoorAddress, "Snowy, 25 Farenheit");

        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayFullDetails();
        Console.WriteLine();
        reception.DisplayShortDescription();
        Console.WriteLine();

        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayFullDetails();
        Console.WriteLine();
        lecture.DisplayShortDescription();
        Console.WriteLine();

        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        outdoor.DisplayFullDetails();
        Console.WriteLine();
        outdoor.DisplayShortDescription();
    }
}