using System;

public class Reference
{
    private string _chapter;
    private string _start;
    private string _end;
    private string _book;

    public Reference(string book, string chapter, string start)
    {
        _chapter = chapter;
        _start = start;
        _book = book;
    }

    public Reference(string book, string chapter, string start, string end)
    {
        _chapter = chapter;
        _book = book;
        _start = start;
        _end = end;
    }

    public string OneVerseReference()
    {
        string chap_verse = string.Format("{0} {1}:{2}", _book, _chapter, _start);
        return chap_verse;
    }

    public string MoreVerseReference()
    {
        string chap_verse = string.Format("{0} {1}:{2}-{3}", _book, _chapter, _start, _end);
        return chap_verse;
    }

}