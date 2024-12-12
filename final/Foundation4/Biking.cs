using System;
using System.Security.Cryptography.X509Certificates;

public class Biking : Activity
{
    private double _speed;
    public Biking(string type, string date, int duration, double speed):base(type, date, duration)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return Math.Round((_speed/60)* Duration, 2);
    }
    public override double GetSpeed()
    {
        return Math.Round(_speed, 2);
    }
    public override double GetPace()
    {
        return Math.Round(Duration/GetDistance(), 2);
    }
}