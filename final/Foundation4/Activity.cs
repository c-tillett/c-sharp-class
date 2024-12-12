using System;
using System.Diagnostics.Contracts;

public abstract class Activity
{
    private string _date;
    private int _duration;
    private string _type;
    public Activity(string type, string date, int duration)
    {
        _type = type;
        _date = date;
        _duration = duration;
    }
    public string Type
    {
        get{return _type;}
        set{_type = value;}
    }
    public string Date
    {
        get{return _date;}
        set{_date = value;}
    }
    public int Duration
    {
        get{return _duration;}
        set{_duration = value;}
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public void PrintSummary()
    {
        Console.WriteLine($"{_date} {_type} ({_duration} minutes)\nDistance: {GetDistance()} miles\nSpeed: {GetSpeed()} Mph\nPace: {GetPace()} mins/mile");
    } 
}