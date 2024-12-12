using System;
using System.Security.Cryptography.X509Certificates;

public class Running : Activity
{
    private double _distance;
    public Running(string type, string date, int duration, double distance):base(type, date, duration)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return Math.Round(_distance ,2);
    }
    public override double GetSpeed()
    {
        return Math.Round((_distance/Duration)*60 ,2);
    }
    public override double GetPace()
    {
        return Math.Round(Duration/_distance, 2);
    }
}