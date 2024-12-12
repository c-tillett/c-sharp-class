using System;

public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _type;
    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = "";
    }
    public string Title
    {
        get{return _title;}
        set{_title = value;}
    }
    public string Description
    {
        get{return _description;}
        set{_description = value;}
    }
    public string Date
    {
        get{return _date;}
        set{_description = value;}
    }
    public string Time
    {
        get{return _time;}
        set{_time = value;}
    }
    public Address Address 
    {
        get{return _address;}
        set{_address = value;}
    }
    protected void SetType(string type)
    {
        _type = type;
    }
    public string GetType()
    {
        return _type;
    }
    public abstract void DisplayFullDetails();
    public void DisplayStandardDetails()
    {
        Console.WriteLine($"{_title}\n{_description}\nOn {_date} at {_time}\n\n{_address.CompileAddress()}");
    }
    public void DisplayShortDescription()
    {
        Console.WriteLine($"This is a {GetType()} event called {Title} being, held on {Date}");
    }
}