using System;

public class Swimming : Activity
{
    private int _laps;
    public Swimming(string type, string date, int duration, int laps):base(type, date, duration)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return Math.Round(_laps * 50 / 1000 * .62, 2);
    }
    public override double GetSpeed()
    {
        return Math.Round((GetDistance()/Duration) * 60, 2);
    }
    public override double GetPace()
    {
        return Math.Round(Duration/GetDistance(), 2);
    }
}