using System;

public class Lecture : Event
{
    private string _speaker;
    private int _maxCapacity;
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int maxCapacity) : base(title, description, date, time, address)
    {
        SetType("Lecture");
        _speaker = speaker;
        _maxCapacity = maxCapacity;
    }
    public override void DisplayFullDetails()
    {
        Console.WriteLine($"{Title} a {GetEventType()} by {_speaker} on\n{Date} at {Time}\n{Address.CompileAddress()}\nGet tickets now, as there are only {_maxCapacity} seats available!");
    }
}