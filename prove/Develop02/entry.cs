using System;
using System.Collections.Generic;

public class Entry
{
    public string _prompt;
    public string _entryInput;
    public DateTime _entryDate;
    public List<string> _promptList;

    public void GetDate()
    {
        _entryDate = DateTime.Now;
        _entryDate.ToShortDateString();
    }

    public void GetPrompt()
    {
        _promptList = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something I learned today?",
            "What is one goal I want to accomplish tomorrow?"
        };

        Random rand = new Random();
        int randomPrompt = rand.Next(_promptList.Count);
        _prompt = _promptList[randomPrompt];
        Console.WriteLine(_prompt);
    }

    public void GetResponse()
    {
        _entryInput = Console.ReadLine();
    }
}
