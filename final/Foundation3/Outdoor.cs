using System;

public class Outdoor : Event
{
    private string _weather;
    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
        SetType("Outdoor");
    }
    public override void DisplayFullDetails()
    {
        Console.WriteLine($"{Title}: an {GetType()} event!\n{Description}\nJoin us on {Date} at {Time}\n{Address.CompileAddress()}\nDress for the weather!\nIt's going to be {_weather}");
    }
}