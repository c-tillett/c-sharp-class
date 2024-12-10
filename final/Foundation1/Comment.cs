using System;
using System.Security.AccessControl;

public class Comment
{
    private string _text;
    private string _commenter;
    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_commenter} - '{_text}'");
    }

}