using System;

public class Job
{
    public string _companyName;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"Spent {_endYear - _startYear} years (from {_startYear} until {_endYear}) as a {_jobTitle} at {_companyName}");
    }
}

