using System;

public class Reception : Event
{
    private string _RSVPdeadline;
    private string _RSVPemail;
    public Reception(string title, string description, string date, string time, Address address, string RSVPdeadline, string RSVPemail) : base(title, description, date, time, address)
    {
        
        _RSVPdeadline = RSVPdeadline;
        _RSVPemail = RSVPemail;
        SetType("Reception");
    }
    public override void DisplayFullDetails()
    {
        Console.WriteLine($"This is a {GetEventType()} event\n{Title}\n{Description}\n{Date} at {Time}\n{Address.CompileAddress()}\n\nPlease RSVP to {_RSVPemail} by {_RSVPdeadline}");
    }
}